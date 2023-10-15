namespace PatternStateEducation.State;

public class RedLightState : ITrafficLight
{
    public void PermissiveSignal(TrafficLight trafficLight){
          Console.WriteLine("Красный заканчивается! Начинается жёлтый!");
          trafficLight.State = new YellowLightState();
    }
    public void ProhibitionSignal(TrafficLight trafficLight){
        Console.WriteLine("Сейчас уже красный!");
    }

}
