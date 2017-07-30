namespace _08.Pet_Clinic.Entites
{
    using System;
    using System.Text;
    using System.Threading;

    public class Clinic
    {
        private int roomsNumber;
        private int occupiedRooms;
        private RoomsRegister roomsRegister;

        public Clinic(string name, int roomsNumber)
        {
            this.Name = name;
            this.RoomsNumber = roomsNumber;
            this.roomsRegister = new RoomsRegister(roomsNumber);
            this.occupiedRooms = 0;
        }
        
        public string Name { get; set; }

        public int RoomsNumber
        {
            get => this.roomsNumber;
            set
            {
                if (value % 2 == 0)
                {
                    throw new ArgumentException();
                }

                this.roomsNumber = value;
            }
        }

        public bool TryAddPet(Pet pet)
        {
            foreach (var roomIndex in this.roomsRegister)
            {
                if (this.roomsRegister[roomIndex] == null)
                {
                    this.roomsRegister[roomIndex] = pet;
                    this.occupiedRooms++;
                    return true;
                }
            }

            return false;
        }

        public bool TryReleasePet()
        {
            int centerRoom = this.RoomsNumber / 2;
            for (int i = 0; i < this.RoomsNumber; i++)
            {
                if (this.roomsRegister[(centerRoom + i) % this.RoomsNumber] != null)
                {
                    this.roomsRegister[(centerRoom + i) % this.RoomsNumber] = null;
                    this.occupiedRooms--;
                    return true;
                }
            }

            return false;
        }

        public bool HasEmptyRooms()
        {
            return this.occupiedRooms < this.RoomsNumber;
        }

        public string Print()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < this.roomsNumber; i++)
            {
                if (this.roomsRegister[i] != null)
                {
                    sb.AppendLine(this.Print(i));
                }
                else
                {
                    sb.AppendLine("Room empty");
                }
            }

            return sb.ToString();
        }

        public string Print(int roomIndex)
        {
            return this.roomsRegister[roomIndex]?.ToString() ?? "Room empty";
        }
    }
}
