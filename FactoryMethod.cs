using System;
using System.Collections.Generic;
using System.Text;

namespace Panel_logistyczny
{

    
    abstract public class IProduct
    {
        public abstract void Operation(string number, int deliveryType, int department, int userID);
    }
    abstract public class Creator
    {
        public abstract IProduct FactoryMethod();

        public void Execute(string number, int deliveryType, int department, int userID)
        {
            var product = FactoryMethod();
            product.Operation(number, deliveryType, department, userID);
            
        }
        
    }

    class CreateRoadDelivery : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new RoadDelivery();
        }
    }
    class CreateWaterDelivery : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new WaterDelivery();
        }
    }
    class CreateAirDelivery : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new AirDelivery();
        }
    }

    class RoadDelivery : IProduct
    {
        public DbProcedures procedures;
        public override void Operation(string number, int deliveryType, int department, int userID)
        {
            procedures.AddItem(number, 1, department, userID);
        }
    }
    class WaterDelivery : IProduct
    {
        public DbProcedures procedures;
        public override void Operation(string number, int deliveryType, int department, int userID)
        {
            procedures.AddItem(number, 2, department, userID);
        }
    }
    class AirDelivery : IProduct
    {
        public DbProcedures procedures;

        public override void Operation(string number, int deliveryType, int department, int userID)
        {
            procedures.AddItem(number, 3, department, userID);
        }
    }

    class Client
    {
        public void ClientCode(Creator creator, string number, int deliveryType, int department, int userID)
        {
            creator.Execute(number, deliveryType, department, userID);
        }
    }
}
