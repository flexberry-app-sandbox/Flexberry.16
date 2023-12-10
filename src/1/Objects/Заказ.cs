﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.1
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Заказ.
    /// </summary>
    // *** Start programmer edit section *** (Заказ CustomAttributes)

    // *** End programmer edit section *** (Заказ CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ЗаказE", new string[] {
            "НомерЗаказа as \'Номер заказа\'",
            "Доставка as \'Доставка\'",
            "Дата as \'Дата\'"})]
    [View("ЗаказL", new string[] {
            "НомерЗаказа as \'Номер заказа\'",
            "Доставка as \'Доставка\'",
            "Дата as \'Дата\'"})]
    public class Заказ : ICSSoft.STORMNET.DataObject
    {
        
        private int fНомерЗаказа;
        
        private System.DateTime fДата;
        
        private IIS.1.ТипДоставки fДоставка;
        
        private IIS.1.Товар fТовар;
        
        private IIS.1.Клиент fКлиент;
        
        private IIS.1.Менеджер fМенеджер;
        
        private IIS.1.DetailArrayOfОплата fОплата;
        
        private IIS.1.DetailArrayOfТовары fТовары;
        
        // *** Start programmer edit section *** (Заказ CustomMembers)

        // *** End programmer edit section *** (Заказ CustomMembers)

        
        /// <summary>
        /// Дата.
        /// </summary>
        // *** Start programmer edit section *** (Заказ.Дата CustomAttributes)

        // *** End programmer edit section *** (Заказ.Дата CustomAttributes)
        public virtual System.DateTime Дата
        {
            get
            {
                // *** Start programmer edit section *** (Заказ.Дата Get start)

                // *** End programmer edit section *** (Заказ.Дата Get start)
                System.DateTime result = this.fДата;
                // *** Start programmer edit section *** (Заказ.Дата Get end)

                // *** End programmer edit section *** (Заказ.Дата Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заказ.Дата Set start)

                // *** End programmer edit section *** (Заказ.Дата Set start)
                this.fДата = value;
                // *** Start programmer edit section *** (Заказ.Дата Set end)

                // *** End programmer edit section *** (Заказ.Дата Set end)
            }
        }
        
        /// <summary>
        /// Доставка.
        /// </summary>
        // *** Start programmer edit section *** (Заказ.Доставка CustomAttributes)

        // *** End programmer edit section *** (Заказ.Доставка CustomAttributes)
        public virtual IIS.1.ТипДоставки Доставка
        {
            get
            {
                // *** Start programmer edit section *** (Заказ.Доставка Get start)

                // *** End programmer edit section *** (Заказ.Доставка Get start)
                IIS.1.ТипДоставки result = this.fДоставка;
                // *** Start programmer edit section *** (Заказ.Доставка Get end)

                // *** End programmer edit section *** (Заказ.Доставка Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заказ.Доставка Set start)

                // *** End programmer edit section *** (Заказ.Доставка Set start)
                this.fДоставка = value;
                // *** Start programmer edit section *** (Заказ.Доставка Set end)

                // *** End programmer edit section *** (Заказ.Доставка Set end)
            }
        }
        
        /// <summary>
        /// НомерЗаказа.
        /// </summary>
        // *** Start programmer edit section *** (Заказ.НомерЗаказа CustomAttributes)

        // *** End programmer edit section *** (Заказ.НомерЗаказа CustomAttributes)
        public virtual int НомерЗаказа
        {
            get
            {
                // *** Start programmer edit section *** (Заказ.НомерЗаказа Get start)

                // *** End programmer edit section *** (Заказ.НомерЗаказа Get start)
                int result = this.fНомерЗаказа;
                // *** Start programmer edit section *** (Заказ.НомерЗаказа Get end)

                // *** End programmer edit section *** (Заказ.НомерЗаказа Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заказ.НомерЗаказа Set start)

                // *** End programmer edit section *** (Заказ.НомерЗаказа Set start)
                this.fНомерЗаказа = value;
                // *** Start programmer edit section *** (Заказ.НомерЗаказа Set end)

                // *** End programmer edit section *** (Заказ.НомерЗаказа Set end)
            }
        }
        
        /// <summary>
        /// Заказ.
        /// </summary>
        // *** Start programmer edit section *** (Заказ.Клиент CustomAttributes)

        // *** End programmer edit section *** (Заказ.Клиент CustomAttributes)
        [PropertyStorage(new string[] {
                "Клиент"})]
        [NotNull()]
        public virtual IIS.1.Клиент Клиент
        {
            get
            {
                // *** Start programmer edit section *** (Заказ.Клиент Get start)

                // *** End programmer edit section *** (Заказ.Клиент Get start)
                IIS.1.Клиент result = this.fКлиент;
                // *** Start programmer edit section *** (Заказ.Клиент Get end)

                // *** End programmer edit section *** (Заказ.Клиент Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заказ.Клиент Set start)

                // *** End programmer edit section *** (Заказ.Клиент Set start)
                this.fКлиент = value;
                // *** Start programmer edit section *** (Заказ.Клиент Set end)

                // *** End programmer edit section *** (Заказ.Клиент Set end)
            }
        }
        
        /// <summary>
        /// Заказ.
        /// </summary>
        // *** Start programmer edit section *** (Заказ.Менеджер CustomAttributes)

        // *** End programmer edit section *** (Заказ.Менеджер CustomAttributes)
        [PropertyStorage(new string[] {
                "Менеджер"})]
        [NotNull()]
        public virtual IIS.1.Менеджер Менеджер
        {
            get
            {
                // *** Start programmer edit section *** (Заказ.Менеджер Get start)

                // *** End programmer edit section *** (Заказ.Менеджер Get start)
                IIS.1.Менеджер result = this.fМенеджер;
                // *** Start programmer edit section *** (Заказ.Менеджер Get end)

                // *** End programmer edit section *** (Заказ.Менеджер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заказ.Менеджер Set start)

                // *** End programmer edit section *** (Заказ.Менеджер Set start)
                this.fМенеджер = value;
                // *** Start programmer edit section *** (Заказ.Менеджер Set end)

                // *** End programmer edit section *** (Заказ.Менеджер Set end)
            }
        }
        
        /// <summary>
        /// Заказ.
        /// </summary>
        // *** Start programmer edit section *** (Заказ.Товар CustomAttributes)

        // *** End programmer edit section *** (Заказ.Товар CustomAttributes)
        [PropertyStorage(new string[] {
                "Товар"})]
        [NotNull()]
        public virtual IIS.1.Товар Товар
        {
            get
            {
                // *** Start programmer edit section *** (Заказ.Товар Get start)

                // *** End programmer edit section *** (Заказ.Товар Get start)
                IIS.1.Товар result = this.fТовар;
                // *** Start programmer edit section *** (Заказ.Товар Get end)

                // *** End programmer edit section *** (Заказ.Товар Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заказ.Товар Set start)

                // *** End programmer edit section *** (Заказ.Товар Set start)
                this.fТовар = value;
                // *** Start programmer edit section *** (Заказ.Товар Set end)

                // *** End programmer edit section *** (Заказ.Товар Set end)
            }
        }
        
        /// <summary>
        /// Заказ.
        /// </summary>
        // *** Start programmer edit section *** (Заказ.Оплата CustomAttributes)

        // *** End programmer edit section *** (Заказ.Оплата CustomAttributes)
        public virtual IIS.1.DetailArrayOfОплата Оплата
        {
            get
            {
                // *** Start programmer edit section *** (Заказ.Оплата Get start)

                // *** End programmer edit section *** (Заказ.Оплата Get start)
                if ((this.fОплата == null))
                {
                    this.fОплата = new IIS.1.DetailArrayOfОплата(this);
                }
                IIS.1.DetailArrayOfОплата result = this.fОплата;
                // *** Start programmer edit section *** (Заказ.Оплата Get end)

                // *** End programmer edit section *** (Заказ.Оплата Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заказ.Оплата Set start)

                // *** End programmer edit section *** (Заказ.Оплата Set start)
                this.fОплата = value;
                // *** Start programmer edit section *** (Заказ.Оплата Set end)

                // *** End programmer edit section *** (Заказ.Оплата Set end)
            }
        }
        
        /// <summary>
        /// Заказ.
        /// </summary>
        // *** Start programmer edit section *** (Заказ.Товары CustomAttributes)

        // *** End programmer edit section *** (Заказ.Товары CustomAttributes)
        public virtual IIS.1.DetailArrayOfТовары Товары
        {
            get
            {
                // *** Start programmer edit section *** (Заказ.Товары Get start)

                // *** End programmer edit section *** (Заказ.Товары Get start)
                if ((this.fТовары == null))
                {
                    this.fТовары = new IIS.1.DetailArrayOfТовары(this);
                }
                IIS.1.DetailArrayOfТовары result = this.fТовары;
                // *** Start programmer edit section *** (Заказ.Товары Get end)

                // *** End programmer edit section *** (Заказ.Товары Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Заказ.Товары Set start)

                // *** End programmer edit section *** (Заказ.Товары Set start)
                this.fТовары = value;
                // *** Start programmer edit section *** (Заказ.Товары Set end)

                // *** End programmer edit section *** (Заказ.Товары Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ЗаказE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗаказE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗаказE", typeof(IIS.1.Заказ));
                }
            }
            
            /// <summary>
            /// "ЗаказL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗаказL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗаказL", typeof(IIS.1.Заказ));
                }
            }
        }
    }
}
