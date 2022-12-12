using Project22GR2.Helpers;
using Project22GR2.Models;
using Project22GR2.Interfaces;

// Author: Luca
// Author's comment: I live in Spain but without the a

namespace Project22GR2.Services
{
    public class JsonBoatRepository : IBoatRepository
    {

        string jsonFileName = @"Data\JsonBoats.json";

        public List<Boat> GetAllBoats()
        {
            // This is used to list out all the boats from the json file
            return JsonFileReader.ReadJsonBoats(jsonFileName);
        }

        public void AddBoat(Boat boat)
        {
            // Lists out all the boats from the json file into a temporary list
            List<Boat> boats = GetAllBoats();
            // Adds the new boat into the list
            boats.Add(boat);
            // Replaces the previous json list with this new list
            JsonFileWriter.WritetoJsonBoats(boats, jsonFileName);
        }

        public Boat GetBoat(int id)
        {
            // Lists out all the boats from the json file into a temporary list
            List<Boat> boats = GetAllBoats();
            // foreach loop that tries to find a boat with the same ID as the input id
            foreach (Boat boat in boats)
            {
                if (boat.Id == id)
                    // if so, returns that boat
                    return boat;
            }
            // if not, returns an empty boat (nothing)
            return new Boat();
        }

        public void DeleteBoat(int id)
        {
            // Lists out all the boats from the json file into a temporary list
            List<Boat> boats = GetAllBoats();
            // Finds the boat that we need to delete
            Boat boatToDelete = GetBoat(id);
            // Deletes the selected boat from the list
            boats.Remove(boatToDelete);
            // Replaces the previous json list with this new list
            JsonFileWriter.WritetoJsonBoats(boats, jsonFileName);

        }

        public void UpdateBoat(Boat boat)
        {
            // First off, checks if the input is valid, so that it doesn't crash if it doesn't
            if (boat != null)
            {
                // Lists out all the boats from the json file into a temporary list
                List<Boat> boats = GetAllBoats();
                // foreach loop that finds the boat in the list with the same ID as the input
                foreach (Boat b in boats)
                {
                    if (b.Id == boat.Id)
                    {
                        // if so, replaces the list boat's attributes with the input boat's
                        b.Id = boat.Id;
                        b.Type = boat.Type;
                        b.Length = boat.Length;
                        b.Width = boat.Width;
                        b.Weight = boat.Weight;
                        b.Sail = boat.Sail;
                    }
                }
                // Updates the json list
                JsonFileWriter.WritetoJsonBoats(boats, jsonFileName);
            }
        }

        public List<Boat> FilterBoats(string filter)
        {
            // Make a new empty list which will hold all of the items that contain the filter
            List<Boat> filteredList = new List<Boat>();
            // foreach loop that finds all items that contains the filter in the Type or Sail (both strings)
            foreach(Boat b in GetAllBoats())
            {
                if(b.Type.Contains(filter) || b.Sail.Contains(filter))
                {
                    // When it finds one, it adds it to the list
                    filteredList.Add(b);
                }
            }
            // When done, returns the list
            return filteredList;
        }

        public List<Boat> GetAllBoatsById(int id)
        {
            List<Boat> booBoats = new List<Boat>();
            List<Boat> boats = GetAllBoats();
            foreach (Boat b in boats)
            {
                if (b.Id == id)
                    booBoats.Add(b);
            }
            return booBoats;
        }
    }
}
