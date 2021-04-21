using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Utilitys
{
    public static class SQLGenerator
    {
        public static String CreateSQLFindIdFromObject(string id, string objectName) => $@"Select * From {objectName} Where Id = '{id}'";

        public static String CreateSQLInsertFromObject(object obj)
        {
            Type objType = obj.GetType();
            List<PropertyInfo> props = new List<PropertyInfo>(objType.GetProperties());

            if (props.Count > 0)
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append($@"Insert Into {obj.GetType().Name} Values (");
                for (int i = 0; i < props.Count; i++)
                {
                    var property = objType.GetProperty(props[i].Name);
                    var tagProp = GetPropertyAttributes(property, "CustomAttribute");
                    if (tagProp == null)
                    {
                        if (i == props.Count - 1)
                        {
                            stringBuilder.Append($@"@{props[i].Name})");
                        }
                        else
                        {
                            stringBuilder.Append($@"@{props[i].Name} ,");
                        }
                    }                    
                }
                return stringBuilder.ToString();
            }
            return "";
        }

        public static String CreateSQLUpdateFromObject(object obj)
        {
            Type objType = obj.GetType();
            List<PropertyInfo> props = new List<PropertyInfo>(objType.GetProperties());

            if (props.Count > 0)
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append($@"Update {obj.GetType().Name} Set ");
                for (int i = 1; i < props.Count; i++)
                {
                    var property = objType.GetProperty(props[i].Name);
                    var tagProp = GetPropertyAttributes(property, "CustomAttribute");
                    if (tagProp == null)
                    {
                        if (i == props.Count - 1)
                        {
                            stringBuilder.Append($@"{props[i].Name} = @{props[i].Name} Where Id = @{props[0].Name}");
                        }
                        else
                        {
                            stringBuilder.Append($@"{props[i].Name} = @{props[i].Name} ,");
                        }
                    }
                }
                return stringBuilder.ToString();
            }
            return "";
        }

        public static String CreateSQLDeleteFromObject(object obj)
        {
            Type objType = obj.GetType();
            List<PropertyInfo> props = new List<PropertyInfo>(objType.GetProperties());

            if (props.Count > 0)
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append($@"Delete From {obj.GetType().Name} Where Id = @Id");
                return stringBuilder.ToString();
            }
            return "";
        }

        private static object GetPropertyAttributes(PropertyInfo prop, string attributeName)
        {
            foreach (CustomAttributeData attribData in prop.GetCustomAttributesData())
            {
                string typeName = attribData.Constructor.DeclaringType.Name;
                if (attribData.ConstructorArguments.Count == 1 &&
                    (typeName == attributeName || typeName == attributeName + "Attribute"))
                {
                    return attribData.ConstructorArguments[0].Value;
                }
            }
            return null;
        }
    }
}
