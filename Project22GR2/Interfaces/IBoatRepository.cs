using Project22GR2.Models;
using System;

namespace Project22GR2.Interfaces
{
    public interface IBoatRepository
    {
        List<Boat> GetAllBoats();
        Boat GetBoat(int id);
        void AddBoat(Boat boat);
        void UpdateBoat(Boat boat);
        void DeleteBoat(int id);
        List<Boat> FilterBoats(string filter);
    }
}
