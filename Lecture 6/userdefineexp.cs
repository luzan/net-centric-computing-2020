using System;

namespace UserDefinedException {
    class TestTemperature {
        static void Main(string[] args) {
            Temperature temp =  new Temperature();
            try {
                temp.showTemp();
            } catch (TempIsZeroException e){
               Console.WriteLine("TemperatureIsZeroException: "+ e.Message);
            }
            Console.ReadKey();
        }
    }
}

public class TempIsZeroException: Exception {
    public TempIsZeroException(string message) : base(message) {

    }
}
public class Temperature {
    int temperature = 5;

    public void showTemp() {
        if(temperature == 0) {
            throw (new TempIsZeroException("Zero Temperature Found"));
        } else {
            Console.WriteLine("Temperature = " + temperature);
        }
    }
}