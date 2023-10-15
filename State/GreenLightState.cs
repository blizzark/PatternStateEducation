namespace PatternStateEducation.State;

public class GreenLightState : ITrafficLight
{

    public void PermissiveSignal(TrafficLight trafficLight){
        Console.WriteLine("Зелёный заканчивается! Начинается мигающий зелёный!");
        trafficLight.State = new FlashingGreenLightState();
    }
    public void ProhibitionSignal(TrafficLight trafficLight){
        Console.WriteLine("Горит зелёный, можно ехать!");
    }
}
