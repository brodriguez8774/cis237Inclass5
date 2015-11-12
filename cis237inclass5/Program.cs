using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Creates collection.
            AdventureWorks2012Entities adventure = new AdventureWorks2012Entities();

            int counter = 0;

            foreach (Person person in adventure.People)
            {
                if (counter > 20)
                {
                    break;
                }
                Console.WriteLine(person.FirstName + " " + person.LastName);
                counter++;
            }

            Console.WriteLine();

            /*
            foreach (EmailAddress email in adventure.EmailAddresses)
            {
                Console.WriteLine(email);
            }
             * */

            // Gets acces to the collection of tables to interact with.
            CarsBRodriguezEntities carsTestEntities = new CarsBRodriguezEntities();

            // READ FROM DATABASE.
            Console.WriteLine(Environment.NewLine + Environment.NewLine);
            Console.WriteLine("Reading from DataBase" + Environment.NewLine);

            // Loop through table and print out for each.
            foreach (Car car in carsTestEntities.Cars)
            {
                Console.WriteLine(car.id + " " + car.make + " " + car.model);
            }
            




            // SEARCH THROUGH DATABASE.
            Console.WriteLine(Environment.NewLine + Environment.NewLine);
            Console.WriteLine("Searching through DataBase" + Environment.NewLine);

            // Using Lambdas?
                                            // Lambda   (Made up variable. Does not matter what it is. => Search through id column => Expected result.)
            // Find a specific car by any property.     (AnyVariable => AnyVariable.ThingToSearchOfVariable == "ExpectedResultHere").Returns the first one found which matches criteria.
            Car carToFind = carsTestEntities.Cars.Where(c => c.id == "V0LCD1814").First();
            Car otherCarToFind = carsTestEntities.Cars.Where(asdf => asdf.model == "Challenger").First();

            // Prints out to console.
            Console.WriteLine(carToFind.id + " " + carToFind.make + " " + carToFind.model);
            Console.WriteLine(otherCarToFind.id + " " + otherCarToFind.make + " " + otherCarToFind.model);
            Console.WriteLine(Environment.NewLine + Environment.NewLine);

            // Pull out a car from table based on primary id.
            Car foundCar = carsTestEntities.Cars.Find("V0LCD1814");

            // Print out.
            Console.WriteLine(foundCar.id + " " + foundCar.make + " " + foundCar.model);




            // ADD TO DATABASE.
            Console.WriteLine(Environment.NewLine + Environment.NewLine);
            Console.WriteLine("Add to DataBase" + Environment.NewLine);

            // Make new instance of car.
            Car newCarTooAdd = new Car();

            // Assign values to car.
            newCarTooAdd.id = "888888";
            newCarTooAdd.make = "Nissan";
            newCarTooAdd.model = "GT-R";
            newCarTooAdd.horsepower = 550;
            newCarTooAdd.cylinders = 8;
            newCarTooAdd.year = "2016";
            newCarTooAdd.type = "Car";

            // Adds the new car to database table
            carsTestEntities.Cars.Add(newCarTooAdd);

            // Save changes to database. Data is not actually saved before this method.
            carsTestEntities.SaveChanges();




            // UPDATE DATABASE.
            Console.WriteLine(Environment.NewLine + Environment.NewLine);
            Console.WriteLine("Update DataBase" + Environment.NewLine);

            // Get car out of database that we want to update.
            Car carToFindForUpdate = carsTestEntities.Cars.Find("V0LCD1814");

            // Update some properties of car. Only need to change the ones we want to update.
            carToFindForUpdate.make = "Nissan";
            carToFindForUpdate.model = "GT-R";
            carToFindForUpdate.horsepower = 550;
            carToFindForUpdate.cylinders = 8;

            // Save the changes to database.
            carsTestEntities.SaveChanges();




            // DELETE FROM DATABASE.
            Console.WriteLine(Environment.NewLine + Environment.NewLine);
            Console.WriteLine("Delete from DataBase" + Environment.NewLine);

            // Get car out of database to delete.
            Car carToFindForDelete = carsTestEntities.Cars.Find("V0LCD1814");

            // Remove from table.
            carsTestEntities.Cars.Remove(carToFindForDelete);

            // Save the changes to database.
            carsTestEntities.SaveChanges();



        }
    }
}
