using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListAdd
{
    class ArrayList1 
    {
      public static void Main(String[] args)  {

      // Creates and initializes a new ArrayList.
      /*ArrayList myAL = new ArrayList();


      myAL.Add( "The" );
      myAL.Add( "quick" );
      myAL.Add( "brown" );
      myAL.Add( "fox" );

                 Console.WriteLine( "The ArrayList initially contains the following:" );
                 foreach(object obj in myAL)
                 {

                     Console.WriteLine(obj);

                 }   
                Console.WriteLine( myAL );

                myAL.Insert(2, "quikest");
                Console.WriteLine(myAL);

                ArrayList  myAL1 = new ArrayList(); 
                myAL1.Add("10");
                myAL1.Add("20");
                myAL1.Add("30");

                foreach (object obj in myAL1)
                {

                    Console.WriteLine(myAL);

                }   
                Console.WriteLine(myAL1);

                myAL.InsertRange(4, myAL1); */

              /*  ArrayList myArryList = new ArrayList();
                myArryList.Add(1);
                myArryList.Add("Two");
                myArryList.Add(3);
                myArryList.Add(4.5f);

                //Access individual item using indexer
                int firstElement = (int)myArryList[0]; //returns 1
                string secondElement = (string)myArryList[1]; //returns "Two"
                int thirdElement = (int)myArryList[2]; //returns 3
                float fourthElement = (float)myArryList[3]; //returns 4.5

                //use var keyword
                var firstEle = myArryList[0]; //returns 1 */

          ArrayList ar = new ArrayList();
          ar.Add("hello ");
          ar.Add("world");
          ar.Add("good ");
          ar.Add("morning");

          foreach(object obj in ar)
          {
             Console.WriteLine(ar);

          }
          ar.Insert(2, "very");

          foreach(object obj in ar)
          {
              Console.WriteLine(ar);
          }


          ArrayList ar2 = new ArrayList();
          ar2.Add("welcome");
          ar2.Add("to");
          ar2.Add("Bangalore"); 
          foreach(object obj in ar2)
          {
              Console.WriteLine(ar2); 
          }

          ar2.InsertRange(0, ar);
          foreach(object ob in ar2)
          {
              Console.WriteLine(ob);
          }

      }
    }
}




