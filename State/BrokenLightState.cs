namespace PatternStateEducation.State;

public class BrokenLightState  : ITrafficLight
{
     public void Broken(TrafficLight trafficLight){
         Console.WriteLine("Уже показывает мигающий жёлтый (сломан)");
     }
    public void PermissiveSignal(TrafficLight trafficLight){
        Console.WriteLine("Светофор починился! Показывает - Зелёный!");
        trafficLight.State = new GreenLightState();
    }
    public void ProhibitionSignal(TrafficLight trafficLight){
        Console.WriteLine("Светофор починился! Показывает - Красный!");
        trafficLight.State = new RedLightState();
    }
}