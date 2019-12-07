using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

static class FileSignatures {

    public struct Sign {
        public byte[] signature;
        public uint offset;
        public string extention;
        public string description;
    }

    public static List<Sign> SignList = null;


    //https://en.wikipedia.org/wiki/List_of_file_signatures //<=
    //https://www.garykessler.net/library/file_sigs.html

    public static void Init() {
        if (!(SignList is null)) return;

        SignList.Add(new Sign() {
            signature   = new byte[] {0x23, 0x21}, //#!
            offset      = 0,
            extention   = null,
            description = "Script or data to be passed to the program following the shebang (#!)" });

        SignList.Add(new Sign() {
            signature   = new byte[] {0xa1, 0xb2, 0xc3, 0xd4},
            offset      = 0,
            extention   = "pcap",
            description = "Libpcap File Format" });

        SignList.Add(new Sign() {
            signature   = new byte[] {0xd4, 0xc3, 0xb2, 0xa1},
            offset      = 0,
            extention   = "pcap",
            description = "Libpcap File Format" });


        SignList.Add(new Sign() {
            signature   = new byte[] { 0x0a, 0x0d, 0x0d, 0x0a },
            offset      = 0,
            extention   = "pcapng",
            description = "PCAP Next Generation Dump File Format"});

        SignList.Add(new Sign() {
            signature   = new byte[] { 0xed, 0xab, 0xee, 0xdb },
            offset      = 0,
            extention   = "rpm",
            description = "RedHat Package Manager (RPM) package"
        });

        SignList.Add(new Sign() {
            signature   = new byte[] { 0x53, 0x51, 0x4c, 0x69, 0x74, 0x65, 0x20, 0x66, 0x6f, 0x72, 0x6d, 0x61, 0x74, 0x20, 0x33, 0x00 }, //SQLite format 3.
            offset      = 0,
            extention   = "sqlitedb, sqlite, db",
            description = "SQLite Database"
        });

        SignList.Add(new Sign() {
            signature   = new byte[] { 0x53, 0x50, 0x30, 0x31 }, //SP01
            offset      = 0,
            extention   = "bin",
            description = "Amazon Kindle Update Package"
        });

        //TODO: add more here

        SignList.Sort((Sign a, Sign b) => {
            //TODO: sort
            return 0;
        });
    }

}
