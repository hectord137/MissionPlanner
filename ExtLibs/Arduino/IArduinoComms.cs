﻿using MissionPlanner.Comms;
using System.Collections.Generic;

namespace MissionPlanner.Arduino
{
    public delegate void ProgressEventHandler(int progress, string status);

    /// <summary>
    ///     Arduino STK interface
    /// </summary>
    public interface IArduinoComms : ICommsSerial
    {
        // from serialport class
        bool connectAP();
        bool keepalive();
        bool sync();
        byte[] download(short length);
        byte[] downloadflash(short length);
        bool setaddress(int address);
        bool upload(byte[] data, short startfrom, short length, short startaddress);
        bool uploadflash(byte[] data, int startfrom, int length, int startaddress);

        Chip getChipType();

        event ProgressEventHandler Progress;
    }

    public class Chip
    {
        private static bool creating = true;

        public static List<Chip> chips = new List<Chip>();
        public string name = "";
        public byte sig1;
        public byte sig2;
        public byte sig3;
        public uint size;

        public Chip(string nm, byte s1, byte s2, byte s3, uint size)
        {
            if (chips.Count == 0 && creating)
                Populate();

            name = nm;
            sig1 = s1;
            sig2 = s2;
            sig3 = s3;
            this.size = size;
        }

        public static void Populate()
        {
            creating = false;

            chips.Clear();

            chips.Add(new Chip("ATmega2561", 0x1e, 0x98, 0x02, 0x100U)); //128 words
            chips.Add(new Chip("ATmega2560", 0x1e, 0x98, 0x01, 0x100U)); //128 words
            chips.Add(new Chip("ATmega1280", 0x1e, 0x97, 0x03, 0x80U)); //128 words
            chips.Add(new Chip("ATmega1281", 0x1e, 0x97, 0x04, 0x80U)); //128 words
            chips.Add(new Chip("ATmega128", 0x1e, 0x97, 0x02, 0x80U)); //128 words
            chips.Add(new Chip("ATmega64", 0x1e, 0x96, 0x02, 0x80U)); //128 words
            chips.Add(new Chip("ATmega32", 0x1e, 0x95, 0x02, 0x40U)); //64 words
            chips.Add(new Chip("ATmega16", 0x1e, 0x94, 0x03, 0x40U)); //64 words
            chips.Add(new Chip("ATmega8", 0x1e, 0x93, 0x07, 0x20U)); //32 words
            chips.Add(new Chip("ATmega88", 0x1e, 0x93, 0x0a, 0x20U)); //32 words
            chips.Add(new Chip("ATmega168", 0x1e, 0x94, 0x06, 0x40U)); //64 words
            chips.Add(new Chip("ATmega328P", 0x1e, 0x95, 0x0F, 0x40U)); //64 words
            chips.Add(new Chip("ATmega162", 0x1e, 0x94, 0x04, 0x40U)); //64 words
            chips.Add(new Chip("ATmega163", 0x1e, 0x94, 0x02, 0x40U)); //64 words
            chips.Add(new Chip("ATmega169", 0x1e, 0x94, 0x05, 0x40U)); //64 words
            chips.Add(new Chip("ATmega8515", 0x1e, 0x93, 0x06, 0x20U)); //32 words
            chips.Add(new Chip("ATmega8535", 0x1e, 0x93, 0x08, 0x20U)); //32 words

            foreach (var item in chips)
            {
                // Console.WriteLine(item);
            }
        }

        public override string ToString()
        {
            return "Chip(" + name + ", " + sig1.ToString("X") + ", " + sig2.ToString("X") + ", " + sig3.ToString("X") +
                   ", " + size + ")";
        }

        public override bool Equals(object obj)
        {
            var item = obj as Chip;
            return item.sig1 == sig1 && item.sig2 == sig2 && item.sig3 == sig3;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}