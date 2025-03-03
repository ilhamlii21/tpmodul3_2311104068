using System;
using System.Collections.Generic;

public enum DoorState
{
    Terkunci,
    Terbuka
}

public class DoorMachine
{
    private DoorState state;

    public DoorMachine()
    {
        state = DoorState.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void BukaPintu()
    {
        if (state == DoorState.Terkunci)
        {
            state = DoorState.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
        else
        {
            Console.WriteLine("Pintu sudah terbuka");
        }
    }

    public void KunciPintu()
    {
        if (state == DoorState.Terbuka)
        {
            state = DoorState.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
        else
        {
            Console.WriteLine("Pintu sudah terkunci");
        }
    }
}

public class KodePos
{
    private Dictionary<string, string> tabelKodePos = new Dictionary<string, string>
    {
        { "Batununggal", "40266" },
        { "Kujangsari", "40287" },
        { "Mengger", "40267" },
        { "Wates", "40256" },
        { "Cijaura", "40287" },
        { "Jatisari", "40286" },
        { "Margasari", "40286" },
        { "Sekajati", "40286" },
        { "Kebonwaru", "40272" },
        { "Maleer", "40274" },
        { "Samoja", "40273" }
    };

    public string GetKodePos(string kelurahan)
    {
        if (tabelKodePos.ContainsKey(kelurahan))
        {
            return tabelKodePos[kelurahan];
        }
        else
        {
            return "Kode pos tidak ditemukan";
        }
    }
}

public class Program
{
    public static void Main()
    {
        DoorMachine pintu = new DoorMachine();
        pintu.BukaPintu();
        pintu.KunciPintu();

        KodePos kodePos = new KodePos();

        Console.Write("Masukkan nama kelurahan: ");
        string inputKelurahan = Console.ReadLine();

        string kode = kodePos.GetKodePos(inputKelurahan);
        Console.WriteLine($"Kode Pos untuk {inputKelurahan}: {kode}");
    }
}
