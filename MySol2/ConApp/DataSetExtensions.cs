﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;

namespace ConApp
{
    public static class DataTableExtensions
    {
        /// <summary>
        /// DataTable 转换为List 集合
        /// </summary>
        /// <typeparam name="TResult">类型</typeparam>
        /// <param name="dt">DataTable</param>
        /// <returns></returns>
        public static List<T> ToList<T>( DataTable dt) where T : class, new()
        {
            ////创建一个属性的列表
            //List<PropertyInfo> prlist = new List<PropertyInfo>();
            ////获取TResult的类型实例  反射的入口
            //Type t = typeof(T);
            ////获得TResult 的所有的Public 属性 并找出TResult属性和DataTable的列名称相同的属性(PropertyInfo) 并加入到属性列表
            //Array.ForEach<PropertyInfo>(t.GetProperties(), p => { if (dt.Columns.IndexOf(p.Name) != -1) prlist.Add(p); });
            ////创建返回的集合
            //List<T> oblist = new List<T>();

            //foreach (DataRow row in dt.Rows)
            //{
            //    //创建TResult的实例
            //    T ob = new T();
            //    //找到对应的数据  并赋值
            //    prlist.ForEach(p => { if (row[p.Name] != DBNull.Value) p.SetValue(ob, row[p.Name], null); });
            //    //放入到返回的集合中.
            //    oblist.Add(ob);
            //}
            //return oblist;

            Type t = typeof(T);
            Array myArr = t.GetProperties();
            List<T> lResult=new List<T>() ;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                T ob=null;

                foreach (PropertyInfo item in myArr)
                {
                    ob = new T();
                    if (dt.Columns.IndexOf(item.Name) != -1)
                    {
                        item.SetValue(ob, dt.Rows[i][item.Name],null);

                    }
                }
                lResult.Add(ob);
            }
           
            return lResult;
        }
    }
}
