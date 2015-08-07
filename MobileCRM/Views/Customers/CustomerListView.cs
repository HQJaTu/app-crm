﻿using System;
using Xamarin.Forms;
using MobileCRM.Views.Base;
using MobileCRM.Statics;
using MobileCRM.Cells;

namespace MobileCRM.Customers
{
    public class CustomerListView : BaseNonPersistentSelectedItemListView
    {
        public CustomerListView()
        {
            HasUnevenRows = false; // Circumvents calculating heights for each cell individually. The rows of this list view will have a static height.
            RowHeight = (int)Sizes.LargeRowHeight; // set the row height for the list view items
            ItemTemplate = new DataTemplate(typeof(CustomerListItemCell));
            SeparatorColor = Palette._014;
        }
    }
}
