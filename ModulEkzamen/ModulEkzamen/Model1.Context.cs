﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ModulEkzamen
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class BookShop : DbContext
{
    public BookShop()
        : base("name=BookShop")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

    public virtual DbSet<Авторы> Авторы { get; set; }

    public virtual DbSet<Книги> Книги { get; set; }

}

}

