using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes_01
{
    [TestClass]
    public class ClassesTest
    {
        [TestMethod]
        public void CookieTests()
        {
            Cookie cookie = new Cookie();
            cookie.Name = "Snickerdoodle";
            cookie.HasNuts = false;

            Cookie anotherCookie = new Cookie();
            anotherCookie.Name = "Something else";
            anotherCookie.GramsOfFlour = 10;

            Cookie snickerdoodle = new Cookie("Snickerdoodle", false, 11.5);
        }

        [TestMethod]
        public void VehicleTest()
        {
            Vehicle car = new Vehicle();
            car.TypeOfVehicle = VehicleType.Car;

            Vehicle newCar = new Vehicle
            {
                TypeOfVehicle = VehicleType.Motorcycle,
                Make = "Honda",
                Model = "Civic",
            };
        }

    }
}
