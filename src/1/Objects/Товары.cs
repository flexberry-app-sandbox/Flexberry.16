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
    /// Товары.
    /// </summary>
    // *** Start programmer edit section *** (Товары CustomAttributes)

    // *** End programmer edit section *** (Товары CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ТоварыE", new string[] {
            "Цена as \'Цена\'",
            "Наименование as \'Наименование\'",
            "Количество as \'Количество\'",
            "Сумма as \'Сумма\'"})]
    public class Товары : ICSSoft.STORMNET.DataObject
    {
        
        private string fНаименование;
        
        private int fКоличество;
        
        private double fЦена;
        
        private double fСумма;
        
        private IIS.1.Заказ fЗаказ;
        
        // *** Start programmer edit section *** (Товары CustomMembers)

        // *** End programmer edit section *** (Товары CustomMembers)

        
        /// <summary>
        /// Количество.
        /// </summary>
        // *** Start programmer edit section *** (Товары.Количество CustomAttributes)

        // *** End programmer edit section *** (Товары.Количество CustomAttributes)
        public virtual int Количество
        {
            get
            {
                // *** Start programmer edit section *** (Товары.Количество Get start)

                // *** End programmer edit section *** (Товары.Количество Get start)
                int result = this.fКоличество;
                // *** Start programmer edit section *** (Товары.Количество Get end)

                // *** End programmer edit section *** (Товары.Количество Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Товары.Количество Set start)

                // *** End programmer edit section *** (Товары.Количество Set start)
                this.fКоличество = value;
                // *** Start programmer edit section *** (Товары.Количество Set end)

                // *** End programmer edit section *** (Товары.Количество Set end)
            }
        }
        
        /// <summary>
        /// Наименование.
        /// </summary>
        // *** Start programmer edit section *** (Товары.Наименование CustomAttributes)

        // *** End programmer edit section *** (Товары.Наименование CustomAttributes)
        [StrLen(255)]
        public virtual string Наименование
        {
            get
            {
                // *** Start programmer edit section *** (Товары.Наименование Get start)

                // *** End programmer edit section *** (Товары.Наименование Get start)
                string result = this.fНаименование;
                // *** Start programmer edit section *** (Товары.Наименование Get end)

                // *** End programmer edit section *** (Товары.Наименование Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Товары.Наименование Set start)

                // *** End programmer edit section *** (Товары.Наименование Set start)
                this.fНаименование = value;
                // *** Start programmer edit section *** (Товары.Наименование Set end)

                // *** End programmer edit section *** (Товары.Наименование Set end)
            }
        }
        
        /// <summary>
        /// Сумма.
        /// </summary>
        // *** Start programmer edit section *** (Товары.Сумма CustomAttributes)

        // *** End programmer edit section *** (Товары.Сумма CustomAttributes)
        public virtual double Сумма
        {
            get
            {
                // *** Start programmer edit section *** (Товары.Сумма Get start)

                // *** End programmer edit section *** (Товары.Сумма Get start)
                double result = this.fСумма;
                // *** Start programmer edit section *** (Товары.Сумма Get end)

                // *** End programmer edit section *** (Товары.Сумма Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Товары.Сумма Set start)

                // *** End programmer edit section *** (Товары.Сумма Set start)
                this.fСумма = value;
                // *** Start programmer edit section *** (Товары.Сумма Set end)

                // *** End programmer edit section *** (Товары.Сумма Set end)
            }
        }
        
        /// <summary>
        /// Цена.
        /// </summary>
        // *** Start programmer edit section *** (Товары.Цена CustomAttributes)

        // *** End programmer edit section *** (Товары.Цена CustomAttributes)
        public virtual double Цена
        {
            get
            {
                // *** Start programmer edit section *** (Товары.Цена Get start)

                // *** End programmer edit section *** (Товары.Цена Get start)
                double result = this.fЦена;
                // *** Start programmer edit section *** (Товары.Цена Get end)

                // *** End programmer edit section *** (Товары.Цена Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Товары.Цена Set start)

                // *** End programmer edit section *** (Товары.Цена Set start)
                this.fЦена = value;
                // *** Start programmer edit section *** (Товары.Цена Set end)

                // *** End programmer edit section *** (Товары.Цена Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.1.Заказ.
        /// </summary>
        // *** Start programmer edit section *** (Товары.Заказ CustomAttributes)

        // *** End programmer edit section *** (Товары.Заказ CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "Заказ"})]
        public virtual IIS.1.Заказ Заказ
        {
            get
            {
                // *** Start programmer edit section *** (Товары.Заказ Get start)

                // *** End programmer edit section *** (Товары.Заказ Get start)
                IIS.1.Заказ result = this.fЗаказ;
                // *** Start programmer edit section *** (Товары.Заказ Get end)

                // *** End programmer edit section *** (Товары.Заказ Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Товары.Заказ Set start)

                // *** End programmer edit section *** (Товары.Заказ Set start)
                this.fЗаказ = value;
                // *** Start programmer edit section *** (Товары.Заказ Set end)

                // *** End programmer edit section *** (Товары.Заказ Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ТоварыE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ТоварыE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ТоварыE", typeof(IIS.1.Товары));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of Товары.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfТовары CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfТовары CustomAttributes)
    public class DetailArrayOfТовары : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.1.DetailArrayOfТовары members)

        // *** End programmer edit section *** (IIS.1.DetailArrayOfТовары members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type Товары by index.
        /// </summary>
        /// <summary>
        /// Adds object with type Товары.
        /// </summary>
        public DetailArrayOfТовары(IIS.1.Заказ fЗаказ) : 
                base(typeof(Товары), ((ICSSoft.STORMNET.DataObject)(fЗаказ)))
        {
        }
        
        public IIS.1.Товары this[int index]
        {
            get
            {
                return ((IIS.1.Товары)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.1.Товары dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
