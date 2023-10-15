namespace PatternStateEducation.State;

public class YellowLightState  : ITrafficLight
{
    public void PermissiveSignal(TrafficLight trafficLight){
        //стадию мигающего зелёного тут заканчиваем
        Console.WriteLine("Жёлтый заканчивается! Начинается зелёный!");
          trafficLight.State = new GreenLightState();
    }
    public void ProhibitionSignal(TrafficLight trafficLight){
        Console.WriteLine("Жёлтый заканчивается, начинается красный!");
        trafficLight.State = new RedLightState();
    }
}
