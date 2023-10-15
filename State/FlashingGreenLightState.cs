namespace PatternStateEducation.State;

public class FlashingGreenLightState  : ITrafficLight
{
    public void PermissiveSignal(TrafficLight trafficLight){

    }
    public void ProhibitionSignal(TrafficLight trafficLight){
        Console.WriteLine("Мигающий зелёный заканчивается, начинается жёлтый!");
        trafficLight.State = new YellowLightState();
    }
}
