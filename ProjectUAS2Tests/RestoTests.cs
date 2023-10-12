using NUnit.Framework;
using ProjectUAS2;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectUAS2.Tests
{
    [TestFixture()]
    public class RestoTests
    {
        Resto res = new Resto();
        [Test()]
        public void NasiGorengTest()
        {
            List<string[]> expected = new List<string[]>
            {
                new string[] {"Nasi Goreng Tests"}
            };
        }

        [Test()]
        public void SteakDagingTest()
        {
            List<string[]> expected = new List<string[]>
            {
                new string[] {"Steak Daging Tests"}
            };
        }

        [Test()]
        public void AyamLadaHitamTest()
        {
             List<string[]> expected = new List<string[]>
            {
                new string[] {"Ayam Lada Hitam Tests"}
            };
        }

        [Test()]
        public void JusManggaTest()
        {
            List<string[]> expected = new List<string[]>
            {
                new string[] {"Jus Mangga Tests"}
            };
        }

        [Test()]
        public void JusApelTest()
        {
            List<string[]> expected = new List<string[]>
            {
                new string[] {"Jus Apel Test"}
            };
        }

        [Test()]
        public void JusAlpukatTest()
        {
            List<string[]> expected = new List<string[]>
            {
                new string[] {"Jus Alpukat Test"}
            };
        }

        [Test()]
        public void PelangganTest()
        {
            List<string[]> expected = new List<string[]>
            {
                new string[] {"Test Pelanggan"}
            };
        }

        [Test()]
        public void TanggalTest()
        {
            List<string[]> expected = new List<string[]>
            {
                new string[] {"Test Tanggal"}
            };
        }

        [Test()]
        public void JamTest()
        {
            List<string[]> expected = new List<string[]>
            {
                new string[] {"Test Jam"}
            };
        }

        [Test()]
        public void KasirTest()
        {
            List<string[]> expected = new List<string[]>
            {
                new string[] {"Test Kasir"}
            };
        }

        [Test()]
        public void RestoFlexTest()
        {
            List<string[]> expected = new List<string[]>
            {
                new string[] {"Test Main Program"}
            };
        }
    }
}