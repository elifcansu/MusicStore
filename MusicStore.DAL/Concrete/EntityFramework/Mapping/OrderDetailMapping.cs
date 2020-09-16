﻿
using MusicStore.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.DAL.Concrete.EntityFramework.Mapping
{
    class OrderDetailMapping :EntityTypeConfiguration<OrderDetail>
    {
        //Order tablosuna ara tablo gibi kullandığımız orderDetail tablosu baseEntity'den kalıtım almadığı için ona repository yazmadık, mapping işlemi yaptık.
        //mapping yapabilmek için öncelikle data.entity içinden EntityTypeConfiguration kütüphanesini ekledik ve haskey anahtar kelimesi ile orderdetail içindeki ID'li olan prop'ları bağladık.
        public OrderDetailMapping()
        {
            HasKey(a => new { a.OrderID, a.AlbumID });
            Property(x => x.Price).HasPrecision(5, 2);
        }

    }
}
