using DapperExtensions.Mapper;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Nankingcigar.CEC.Dapper.Mapper
{
  public abstract class BaseMapper<T> : ClassMapper<T> where T : class
  {
    public BaseMapper()
    {
      var type = typeof(T);
      var attributes = type.GetCustomAttributes(typeof(TableAttribute), true);
      var tableName = type.Name;
      if (attributes != null && attributes.Length > 0)
      {
        tableName = ((TableAttribute)attributes[0]).Name;
      }
      Table(tableName);
      var properties = type.GetProperties().Where(entity => entity.CanWrite && entity.CanRead && !entity.PropertyType.IsValueType && entity.PropertyType != typeof(string) && entity.PropertyType != typeof(Nullable<>));
      foreach (var property in properties)
      {
        Map(property).Ignore();
      }
      AutoMap();
    }
  }
}