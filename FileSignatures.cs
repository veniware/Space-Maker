using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

static class FileSignatures {

    //https://en.wikipedia.org/wiki/List_of_file_signatures
    //https://www.garykessler.net/library/file_sigs.html

    public struct Sign {
        public byte[] signature;
        public uint offset;
        public string extention;
        public string description;
    }

    public static List<Sign> SignList = null;

    public static void Init() {
        if (!(SignList is null)) return;

        {
            SignList.Add(new Sign() {
                signature = new byte[] { 0x23, 0x21 }, //#!
                offset = 0,
                extention = null,
                description = "Script or data to be passed to the program following the shebang (#!)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xa1, 0xb2, 0xc3, 0xd4 },
                offset = 0,
                extention = "pcap",
                description = "Libpcap File Format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xd4, 0xc3, 0xb2, 0xa1 },
                offset = 0,
                extention = "pcap",
                description = "Libpcap File Format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x0a, 0x0d, 0x0d, 0x0a },
                offset = 0,
                extention = "pcapng",
                description = "PCAP Next Generation Dump File Format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xed, 0xab, 0xee, 0xdb },
                offset = 0,
                extention = "rpm",
                description = "RedHat Package Manager (RPM) package"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x53, 0x51, 0x4c, 0x69, 0x74, 0x65, 0x20, 0x66, 0x6f, 0x72, 0x6d, 0x61, 0x74, 0x20, 0x33, 0x00 }, //SQLite format 3.
                offset = 0,
                extention = "sqlitedb, sqlite, db",
                description = "SQLite Database"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x53, 0x50, 0x30, 0x31 }, //SP01
                offset = 0,
                extention = "bin",
                description = "Amazon Kindle Update Package"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xBE, 0xBA, 0xFE, 0xCA },
                offset = 0,
                extention = "dba",
                description = "Palm Desktop Calendar Archive"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x01, 0x42, 0x44 },
                offset = 0,
                extention = "dba",
                description = "Palm Desktop To Do Archive"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x01, 0x44, 0x54 },
                offset = 0,
                extention = "tda",
                description = "Palm Desktop Calendar Archive"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x54, 0x44, 0x46, 0x24 }, //TDF$
                offset = 0,
                extention = "tdf$",
                description = "Telegram Desktop File"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x54, 0x44, 0x45, 0x46 }, //TDEF
                offset = 0,
                extention = "tdef",
                description = "Telegram Desktop Encrypted File"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x01, 0x00, 0x00 },
                offset = 0,
                extention = null,
                description = "Palm Desktop Data File (Access format)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x00, 0x01, 0x00 },
                offset = 0,
                extention = "ico",
                description = "Windows icon file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x01, 0x00, 0x00 },
                offset = 0,
                extention = "ico",
                description = "Windows icon file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x66, 0x74, 0x79, 0x70, 0x33, 0x67 }, //ftyp3g
                offset = 4,
                extention = "3gp, 3g2",
                description = "3rd Generation Partnership Project 3GPP and 3GPP2 multimedia files"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x1F, 0x9D },
                offset = 0,
                extention = "z, tar.z",
                description = "compressed file (Lempel-Ziv-Welch algorithm)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x1F, 0xA0 },
                offset = 0,
                extention = "z, tar.z",
                description = "compressed file (LZH algorithm)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x42, 0x41, 0x43, 0x4B, 0x4D, 0x49, 0x4B, 0x45, 0x44, 0x49, 0x53, 0x4B }, //BACKMIKE DISK
                offset = 0,
                extention = "bac",
                description = "File or tape containing a backup done with AmiBack on an Amiga"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x42, 0x5A, 0x68 }, //BZh
                offset = 0,
                extention = "bz2",
                description = "	Compressed file (Bzip2 algorithm)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x47, 0x49, 0x46, 0x38, 0x37, 0x61 }, //GIF87a
                offset = 0,
                extention = "gif",
                description = "Graphics Interchange Format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x47, 0x49, 0x46, 0x38, 0x39, 0x61 }, //GIF89a
                offset = 0,
                extention = "gif",
                description = "Graphics Interchange Format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x49, 0x49, 0x2A, 0x00 },
                offset = 0,
                extention = "tif, tiff",
                description = "Tagged Image File Format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4D, 0x4D, 0x00, 0x2A },
                offset = 0,
                extention = "tif, tiff",
                description = "Tagged Image File Format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4D, 0x4D, 0x00, 0x2B },
                offset = 0,
                extention = "tif, tiff",
                description = "Tagged Image File Format (BigTIFF > 4GB)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x49, 0x49, 0x2A, 0x00, 0x10, 0x00, 0x00, 0x00, 0x43, 0x52 },
                offset = 0,
                extention = "cr2",
                description = "Canon's RAW format is based on the TIFF file format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x80, 0x2A, 0x5F, 0xD7 },
                offset = 0,
                extention = "cin",
                description = "Kodak Cineon image"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x52, 0x4E, 0x43, 0x01 },
                offset = 0,
                extention = null,
                description = "Compressed file (Rob Northen Compression)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x52, 0x4E, 0x43, 0x02 },
                offset = 0,
                extention = null,
                description = "Compressed file (Rob Northen Compression)"
            });


            SignList.Add(new Sign() {
                signature = new byte[] { 0x53, 0x44, 0x50, 0x58 }, //SDPX
                offset = 0,
                extention = "dpx",
                description = "SMPTE DPX image"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x58, 0x50, 0x44, 0x53 }, //XPDS
                offset = 0,
                extention = "dpx",
                description = "SMPTE DPX image"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x76, 0x2F, 0x31, 0x01 },
                offset = 0,
                extention = "exr",
                description = "OpenEXR image"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x42, 0x50, 0x47, 0xFB },
                offset = 0,
                extention = "bpg",
                description = "Better Portable Graphics format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xFF, 0xD8, 0xFF, 0xDB },
                offset = 0,
                extention = "jpg, jpeg",
                description = "	JPEG raw or in the JFIF or Exif file format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xFF, 0xD8, 0xFF, 0xE0, 0x00, 0x10, 0x4A, 0x46, 0x49, 0x46, 0x00, 0x01 },
                offset = 0,
                extention = "jpg, jpeg",
                description = "	JPEG raw or in the JFIF or Exif file format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xFF, 0xD8, 0xFF, 0xEE },
                offset = 0,
                extention = "jpg, jpeg",
                description = "	JPEG raw or in the JFIF or Exif file format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x49, 0x4E, 0x44, 0x58 }, //INDX
                offset = 0,
                extention = "idx",
                description = "Index file to a file or tape containing a backup done with AmiBack on an Amiga"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4C, 0x5A, 0x49, 0x50 }, //LZIP
                offset = 0,
                extention = "lz",
                description = "	lzip compressed file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4D, 0x5A }, //MZ
                offset = 0,
                extention = "exe, dll",
                description = "DOS MZ executable file format and its descendants (including NE and PE)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x50, 0x4B, 0x03, 0x04 },
                offset = 0,
                extention = "zip, aar, apk, docx, epub, ipa, jar, kmz, maff, odp, ods, odt, pk3, pk4, pptx, usdz, vsdx, xlsx, xpi",
                description = "zip file format and formats based on it, such as EPUB, JAR, ODF, OOXML"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x50, 0x4B, 0x05, 0x06 },
                offset = 0,
                extention = "zip, aar, apk, docx, epub, ipa, jar, kmz, maff, odp, ods, odt, pk3, pk4, pptx, usdz, vsdx, xlsx, xpi",
                description = "zip file format and formats based on it, such as EPUB, JAR, ODF, OOXML"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x50, 0x4B, 0x07, 0x08 },
                offset = 0,
                extention = "zip, aar, apk, docx, epub, ipa, jar, kmz, maff, odp, ods, odt, pk3, pk4, pptx, usdz, vsdx, xlsx, xpi",
                description = "zip file format and formats based on it, such as EPUB, JAR, ODF, OOXML"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x52, 0x61, 0x72, 0x21, 0x1A, 0x07, 0x00 },
                offset = 0,
                extention = "rar",
                description = "RAR archive version 1.50 onwards"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x52, 0x61, 0x72, 0x21, 0x1A, 0x07, 0x01, 0x00 },
                offset = 0,
                extention = "rar",
                description = "RAR archive version 5.0 onwards"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x7F, 0x45, 0x4C, 0x46 }, //.ELF
                offset = 0,
                extention = null,
                description = "Executable and Linkable Format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A },
                offset = 0,
                extention = "png",
                description = "Portable Network Graphics format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xCA, 0xFE, 0xBA, 0xBE },
                offset = 0,
                extention = "class",
                description = "Java class file, Mach-O Fat Binary"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xEF, 0xBB, 0xBF },
                offset = 0,
                extention = null,
                description = "UTF-8 encoded Unicode byte order mark"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xFE, 0xED, 0xFE, 0xED },
                offset = 0,
                extention = null,
                description = "JKS JavakeyStore"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xCE, 0xFA, 0xED, 0xFE },
                offset = 0,
                extention = null,
                description = "Mach-O binary (reverse byte ordering scheme, 32-bit)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xCF, 0xFA, 0xED, 0xFE },
                offset = 0,
                extention = null,
                description = "Mach-O binary (reverse byte ordering scheme, 64-bit)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xFF, 0xFE },
                offset = 0,
                extention = null,
                description = "	Byte-order mark for text file encoded in little-endian 16-bit Unicode Transfer Format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xFF, 0xFE, 0x00, 0x00 },
                offset = 0,
                extention = null,
                description = "Byte-order mark for text file encoded in little-endian 32-bit Unicode Transfer Format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x25, 0x21, 0x50, 0x53 }, //%!PS
                offset = 0,
                extention = "ps",
                description = "PostScript document"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x25, 0x50, 0x44, 0x46, 0x2d }, //%PDF-
                offset = 0,
                extention = "pdf",
                description = "PDF document"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x30, 0x26, 0xB2, 0x75, 0x8E, 0x66, 0xCF, 0x11, 0xA6, 0xD9, 0x00, 0xAA, 0x00, 0x62, 0xCE, 0x6C },
                offset = 0,
                extention = "asf, wma, wmv",
                description = "Advanced Systems Format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x24, 0x53, 0x44, 0x49, 0x30, 0x30, 0x30, 0x31 }, //$SDI0001
                offset = 0,
                extention = null,
                description = "System Deployment Image, a disk image format used by Microsoft"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4F, 0x67, 0x67, 0x53 }, //OggS
                offset = 0,
                extention = "ogg, oga, ogv",
                description = "Ogg, open source media container format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x38, 0x42, 0x50, 0x53 }, //8BPS
                offset = 0,
                extention = "psd",
                description = "Photoshop Document file, Adobe Photoshop's native file format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xFF, 0xFB },
                offset = 0,
                extention = "mp3",
                description = "MPEG-1 Layer 3 file without an ID3 tag or with an ID3v1 tag (which's appended at the end of the file)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x49, 0x44, 0x33 }, //ID3
                offset = 0,
                extention = "mp3",
                description = "MP3 file with an ID3v2 container"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x42, 0x4D }, //BM
                offset = 0,
                extention = "bmp, dib",
                description = "BMP file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x43, 0x44, 0x30, 0x30, 0x31 }, //CD001
                offset = 0,
                extention = "iso",
                description = "ISO9660 CD/DVD image file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x53, 0x49, 0x4D, 0x50, 0x4C, 0x45, 0x20, 0x20, 0x3D, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x54 },
                offset = 0,
                extention = "fits",
                description = "Flexible Image Transport System (FITS)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x66, 0x4C, 0x61, 0x43 }, //fLaC
                offset = 0,
                extention = "flac",
                description = "Free Lossless Audio Codec"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4D, 0x54, 0x68, 0x64 }, //MThd
                offset = 0,
                extention = "mid, midi",
                description = "Musical Instrument Digital Interface (MIDI) sound file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 },
                offset = 0,
                extention = "doc, xls, ppt, msg",
                description = "Compound File Binary Format, a container format used for document by older versions of Microsoft Office. It is however an open format used by other programs as well."
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x64, 0x65, 0x78, 0x0A, 0x30, 0x33, 0x35, 0x00 },
                offset = 0,
                extention = "dex",
                description = "Dalvik Executable"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("KDM"),
                offset = 0,
                extention = "vmdk",
                description = "VMDK files"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("Cr24"),
                offset = 0,
                extention = "crx",
                description = "Google Chrome extension or packaged app"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("AGD3"),
                offset = 0,
                extention = "fh8",
                description = "FreeHand 8 document"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x05, 0x07, 0x00, 0x00, 0x42, 0x4F, 0x42, 0x4F, 0x05, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 },
                offset = 0,
                extention = "cwk",
                description = "AppleWorks 5 document"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x06, 0x07, 0xE1, 0x00, 0x42, 0x4F, 0x42, 0x4F, 0x06, 0x07, 0xE1, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 },
                offset = 0,
                extention = "cwk",
                description = "AppleWorks 6 document"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x45, 0x52, 0x02, 0x00, 0x00, 0x00 },
                offset = 0,
                extention = "toast",
                description = "Roxio Toast disc image file, also some .dmg-files begin with same bytes"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x8B, 0x45, 0x52, 0x02, 0x00, 0x00, 0x00 },
                offset = 0,
                extention = "toast",
                description = "Roxio Toast disc image file, also some .dmg-files begin with same bytes"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x78, 0x01, 0x73, 0x0D, 0x62, 0x62, 0x60 },
                offset = 0,
                extention = "dmg",
                description = "Apple Disk Image file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("xar!"),
                offset = 0,
                extention = "xar",
                description = "eXtensible ARchive format"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("PMOCCMOC"),
                offset = 0,
                extention = "dat",
                description = "Windows Files And Settings Transfer Repository"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4E, 0x45, 0x53, 0x1A },
                offset = 0,
                extention = "nes",
                description = "Nintendo Entertainment System ROM file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x75, 0x73, 0x74, 0x61, 0x72, 0x00, 0x30, 0x30 },
                offset = 257,
                extention = "tar",
                description = "tar archive"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x75, 0x73, 0x74, 0x61, 0x72, 0x20, 0x20, 0x00 },
                offset = 257,
                extention = "tar",
                description = "tar archive"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x74, 0x6F, 0x78, 0x33 },
                offset = 0,
                extention = "tox",
                description = "Open source portable voxel file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4D, 0x4C, 0x56, 0x49 }, //MLVI
                offset = 0,
                extention = "mvl",
                description = "Magic Lantern Video file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x44, 0x43, 0x4D, 0x01, 0x50, 0x41, 0x33, 0x30 }, //DCM PA30
                offset = 0,
                extention = null,
                description = "Windows Update Binary Delta Compression"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x37, 0x7A, 0xBC, 0xAF, 0x27, 0x1C },
                offset = 0,
                extention = "7z",
                description = "7-Zip File Format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x1F, 0x8B },
                offset = 0,
                extention = "gzm, tar.gz",
                description = "GZIP compressed file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xFD, 0x37, 0x7A, 0x58, 0x5A, 0x00, 0x00 },
                offset = 0,
                extention = "xz, tar.xz",
                description = "XZ compression utility (LZMA2 compression)"
            });
            SignList.Add(new Sign() {
                signature = new byte[] { 0x04, 0x22, 0x4D, 0x18 },
                offset = 0,
                extention = "lz4",
                description = "LZ4 Frame Format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4D, 0x53, 0x43, 0x46 },
                offset = 0,
                extention = "cab",
                description = "Microsoft Cabinet file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x53, 0x5A, 0x44, 0x44, 0x88, 0xF0, 0x27, 0x33 },
                offset = 0,
                extention = null,
                description = "Microsoft compressed file in Quantum format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x46, 0x4C, 0x49, 0x46 }, //FLIF
                offset = 0,
                extention = "flif	",
                description = "Free Lossless Image Format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x1A, 0x45, 0xDF, 0xA3 },
                offset = 0,
                extention = "mkv, mka, mks, mk3d, webm",
                description = "Matroska media container, including WebM"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4D, 0x49, 0x4C, 0x20 },
                offset = 0,
                extention = "stg",
                description = "Rpw: Rowperfect for Windows, RP3W: ROWPERFECT3 for Windows"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x41, 0x54, 0x26, 0x54, 0x46, 0x4F, 0x52, 0x4D },
                offset = 0,
                extention = "djvu, djv",
                description = "DjVu document"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x30, 0x82 },
                offset = 0,
                extention = "der",
                description = "DER encoded X.509 certificate"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x44, 0x49, 0x43, 0x4D },
                offset = 128,
                extention = "dcm",
                description = "DICOM Medical File Format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x77, 0x4F, 0x46, 0x46 }, //wOFF
                offset = 0,
                extention = "woff",
                description = "WOFF File Format 1.0"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x77, 0x4F, 0x46, 0x32 }, //wOF2
                offset = 0,
                extention = "woff2",
                description = "WOFF File Format 2.0"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x3c, 0x3f, 0x78, 0x6d, 0x6c, 0x20 }, //<?xml 
                offset = 0,
                extention = "xml",
                description = "eXtensible Markup Language when using the ASCII character encoding"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x61, 0x73, 0x6d }, //.asm
                offset = 0,
                extention = "wasm",
                description = "WebAssembly binary format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xcf, 0x84, 0x01 },
                offset = 0,
                extention = "lep",
                description = "Lepton compressed JPEG image"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x43, 0x57, 0x53 }, //CWS
                offset = 0,
                extention = "swf",
                description = "Flash file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x46, 0x57, 0x53 }, //FWS
                offset = 0,
                extention = "swf",
                description = "Flash file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x21, 0x3C, 0x61, 0x72, 0x63, 0x68, 0x3E }, //!<arch>.
                offset = 0,
                extention = "deb",
                description = "linux deb file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x52, 0x49, 0x46, 0x46 },
                offset = 0,
                extention = "webp",
                description = "Google WebP image file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x27, 0x05, 0x19, 0x56 },
                offset = 0,
                extention = null,
                description = "U-Boot / uImage. Das U-Boot Universal Boot Loader"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x7B, 0x5C, 0x72, 0x74, 0x66, 0x31 }, //{\rtf1
                offset = 0,
                extention = "rtf",
                description = "Rich Text Format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x54, 0x41, 0x50, 0x45 }, //TAPE
                offset = 0,
                extention = null,
                description = "Microsoft Tape Format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x74 }, //G
                offset = 0,
                extention = "tx, tsv, tsa",
                description = "MPEG Transport Stream (MPEG-2)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x00, 0x01, 0xBA },
                offset = 0,
                extention = "m2p, vob",
                description = "MPEG Program Stream (MPEG-1 (essentially identical) and MPEG-2)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { },
                offset = 0,
                extention = "mpg, mpeg",
                description = "MPEG-1 video and MPEG-2 video"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x00, 0x01, 0xB3 },
                offset = 0,
                extention = "mpg, mpeg",
                description = "MPEG-1 video and MPEG-2 video"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x78, 0x01 },
                offset = 0,
                extention = "zlib",
                description = "zlib file (no/low compression)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x78, 0x9C },
                offset = 0,
                extention = "zlib",
                description = "zlib file (default  compression)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x78, 0xDA },
                offset = 0,
                extention = "zlib",
                description = "zlib file (best compression)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x62, 0x76, 0x78, 0x32 }, //bvx2
                offset = 0,
                extention = "lzfse",
                description = "LZFSE (Lempel-Ziv style data compression algorithm, Finite State Entropy coding. OSS by Apple)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4f, 0x52, 0x43 }, //ORC
                offset = 0,
                extention = "orc",
                description = "	Apache ORC (Optimized Row Columnar) file format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4F, 0x62, 0x6A, 0x01 }, //Obj.
                offset = 0,
                extention = "avro",
                description = "Apache Avro binary file format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x53, 0x45, 0x51, 0x36 }, //SEQ6
                offset = 0,
                extention = "rc",
                description = "RCFile columnar file format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x65, 0x87, 0x78, 0x56 },
                offset = 0,
                extention = "p25, obt",
                description = "PhotoCap Object Templates"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x55, 0x55, 0xaa, 0xaa },
                offset = 0,
                extention = "pcv",
                description = "PhotoCap Vector"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x78, 0x56, 0x34 }, //xV4
                offset = 0,
                extention = "pbt, pdt, pea, peb, pet, pgt, pict, pjt, pkt, pmt",
                description = "PhotoCap Template"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x50, 0x41, 0x52, 0x31 }, //PAR1
                offset = 0,
                extention = null,
                description = "Apache Parquet columnar file format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x45, 0x4D, 0x58, 0x32 }, //EMX2
                offset = 0,
                extention = "ez2",
                description = "Emulator Emaxsynth samples"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x45, 0x4D, 0x55, 0x33 }, //EMU3
                offset = 0,
                extention = "ez3, iso",
                description = "Emulator III synth samples"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x1B, 0x4C, 0x75, 0x61 },
                offset = 0,
                extention = "luac",
                description = "Lua bytecode"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x62, 0x6F, 0x6F, 0x6B, 0x00, 0x00, 0x00, 0x00, 0x6D, 0x61, 0x72, 0x6B, 0x00, 0x00, 0x00, 0x00 },
                offset = 0,
                extention = "alias",
                description = "macOS file Alias (Symbolic link)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x5B, 0x5A, 0x6F, 0x6E, 0x65, 0x54, 0x72, 0x61, 0x6E, 0x73, 0x66, 0x65, 0x72, 0x5D }, //[ZoneTransfer]
                offset = 0,
                extention = "Identifier",
                description = "Microsoft Zone Identifier for URL Security Zones"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x52, 0x65, 0x63, 0x65, 0x69, 0x76, 0x65, 0x64 }, //Received:
                offset = 0,
                extention = "eml",
                description = "Email Message var5"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x20, 0x02, 0x01, 0x62, 0xA0, 0x1E, 0xAB, 0x07, 0x02, 0x00, 0x00, 0x00 },
                offset = 0,
                extention = "tde",
                description = "Tableau Datasource"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x37, 0x48, 0x03, 0x02, 0x00, 0x00, 0x00, 0x00, 0x58, 0x35, 0x30, 0x39, 0x4B, 0x45, 0x59 },
                offset = 0,
                extention = "kdb",
                description = "KDB file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x28, 0xB5, 0x2F, 0xFD },
                offset = 0,
                extention = "zst",
                description = "Zstandard compressed file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x3A, 0x29, 0x0A }, //:).
                offset = 0,
                extention = "sml",
                description = "Smile file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00 },
                offset = 0,
                extention = "tbi",
                description = "Windows Disk Image file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x62, 0x31, 0x05, 0x00, 0x09, 0x00, 0x00, 0x00, 0x00, 0x20, 0x00, 0x00, 0x00, 0x09, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00},
                offset = 8,
                extention = "dat",
                description = "Bitcoin Core wallet file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x00, 0x00, 0x0C, 0x6A, 0x50, 0x20, 0x20, 0x0D, 0x0A },
                offset = 0,
                extention = "jp2, jpg, jpe, jpeg, jfif",
                description = "JPEG-2000 image file formats"
            });
                        
            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x00, 0x02, 0x00 },
                offset = 0,
                extention = "cur",
                description = "Windows cursor file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x00, 0x02, 0x00, 0x06, 0x04, 0x06, 0x00, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00},
                offset = 0,
                extention = "wk1",
                description = "Lotus 1-2-3 spreadsheet (v1)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x00, 0x1A, 0x00, 0x00, 0x10, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00 },
                offset = 0,
                extention = "wk3",
                description = "Lotus 1-2-3 spreadsheet (v3)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x00, 0x1A, 0x00, 0x02, 0x10, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00 },
                offset = 0,
                extention = "wk4, wk5",
                description = "Lotus 1-2-3 spreadsheet (v4, v5)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x00, 0x1A, 0x00, 0x05, 0x10, 0x04 },
                offset = 0,
                extention = "123",
                description = "Lotus 1-2-3 spreadsheet (v9)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x00, 0x03, 0xF3 },
                offset = 0,
                extention = null,
                description = "Amiga Hunk executable file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x00, 0x49, 0x49, 0x58, 0x50, 0x52 },
                offset = 0,
                extention = "qxd",
                description = "Quark Express document (Intel)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x00, 0x4D, 0x4D, 0x58, 0x50, 0x52 },
                offset = 0,
                extention = "qxd",
                description = "Quark Express document (Motorola)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF },
                offset = 6,
                extention = "hlp",
                description = "Windows Help file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00 },
                offset = 0,
                extention = "ttf",
                description = "TrueType font file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x4D, 0x53, 0x49, 0x53, 0x41, 0x4D, 0x20, 0x44, 0x61, 0x74, 0x61, 0x62, 0x61, 0x73, 0x65 },
                offset = 0,
                extention = "mny",
                description = "Microsoft Money file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x53, 0x74, 0x61, 0x6E, 0x64, 0x61, 0x72, 0x64, 0x20, 0x41, 0x43, 0x45, 0x20, 0x44, 0x42 },
                offset = 0,
                extention = "accdb",
                description = "Microsoft Access 2007 file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x01, 0x00, 0x00, 0x53, 0x74, 0x61, 0x6E, 0x64, 0x61, 0x72, 0x64, 0x20, 0x4A, 0x65, 0x74, 0x20, 0x44, 0x42 },
                offset = 0,
                extention = "mdb",
                description = "Microsoft Access file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x01, 0x00, 0x08, 0x00, 0x01, 0x00, 0x01, 0x01 },
                offset = 0,
                extention = "img",
                description = "Ventura Publisher/GEM VDI Image Format Bitmap file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x01, 0x01 },
                offset = 0,
                extention = "flt",
                description = "OpenFlight 3D file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x01, 0x42, 0x41 },
                offset = 0,
                extention = "aba",
                description = "Palm Address Book Archive file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x01, 0x42, 0x44 },
                offset = 0,
                extention = "dba",
                description = "Palm DateBook Archive file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x06, 0x15, 0x61, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x04, 0xD2, 0x00, 0x00, 0x10, 0x00 },
                offset = 0,
                extention = "db",
                description = "Netscape Navigator (v4) database file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x0D, 0xBB, 0xA0 },
                offset = 0,
                extention = null,
                description = "Mbox table of contents file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x11, 0xAF },
                offset = 0,
                extention = "fli",
                description = "FLIC Animation file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x14, 0x00, 0x00, 0x01, 0x02 },
                offset = 0,
                extention = null,
                description = "BIOS details in RAM images"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x1E, 0x84, 0x90, 0x00, 0x00, 0x00, 0x00 },
                offset = 0,
                extention = "snm",
                description = "Netscape Communicator (v4) mail folder"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x20, 0xAF, 0x30 },
                offset = 0,
                extention = "tpl",
                description = "Wii images container"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x5C, 0x41, 0xB1, 0xFF },
                offset = 0,
                extention = "enc",
                description = "Mujahideen Secrets 2 encrypted file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0x6E, 0x1E, 0xF0 },
                offset = 512,
                extention = "ppt",
                description = "Microsoft PowerPoint presentation subheader"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x0F, 0x00, 0xE8, 0x03 },
                offset = 512,
                extention = "ppt",
                description = "Microsoft PowerPoint presentation subheader"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x09, 0x08, 0x10, 0x00, 0x00, 0x06, 0x05, 0x00 },
                offset = 512,
                extention = "xls",
                description = "Microsoft Excel spreadsheet subheader"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0xBF },
                offset = 0,
                extention = "sol",
                description = "Adobe Flash shared object file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x00, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x02, 0x00, 0x01 },
                offset = 0,
                extention = "mdf",
                description = "Alcohol 120% CD image"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x01, 0x00, 0x09, 0x00, 0x00, 0x03 },
                offset = 0,
                extention = "wmf",
                description = "Windows Metadata file (Win 3.x format)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x01, 0x00, 0x02, 0x00 },
                offset = 0,
                extention = "arf",
                description = "Webex Advanced Recording Format files."
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x01, 0x00, 0x39, 0x30 },
                offset = 0,
                extention = "fdb, gdb",
                description = "Firebird and Interbase database files"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x01, 0x01, 0x47, 0x19, 0xA4, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00},
                offset = 0,
                extention = "tbi",
                description = "	The Bat! secure e-mail Message Base Index file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x01, 0x0F, 0x00, 0x00 },
                offset = 0,
                extention = "mdf",
                description = "Microsoft SQL Server 2000 database"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x01, 0x10 },
                offset = 0,
                extention = "tr1",
                description = "Novell LANalyzer capture file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x01, 0xDA, 0x01, 0x01, 0x00, 0x03 },
                offset = 0,
                extention = "rgb",
                description = "Silicon Graphics RGB Bitmap"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x01, 0xFF, 0x02, 0x04, 0x03, 0x02 },
                offset = 0,
                extention = "drw",
                description = "Micrografx vector graphic file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x02, 0x64, 0x73, 0x73 },
                offset = 0,
                extention = "dss",
                description = "Digital Speech Standard"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x03, 0x00, 0x00, 0x00 },
                offset = 0,
                extention = "qph",
                description = "Quicken price history file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x03, 0x00, 0x00, 0x00, 0x41, 0x50, 0x50, 0x52 },
                offset = 0,
                extention = "adx",
                description = "Approach index file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x06, 0x06, 0xED, 0xF5, 0xD8, 0x1D, 0x46, 0xE5, 0xBD, 0x31, 0xEF, 0xE7, 0xFE, 0x74, 0xB7, 0x1D },
                offset = 0,
                extention = "indd",
                description = "Adobe InDesign document"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x06, 0x0E, 0x2B, 0x34, 0x02, 0x05, 0x01, 0x01, 0x0D, 0x01, 0x02, 0x01, 0x01, 0x02 },
                offset = 0,
                extention = "mxf",
                description = "Material Exchange Format file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x07, 0x53, 0x4B, 0x46 },
                offset = 0,
                extention = "skf",
                description = "SkinCrafter skin file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x07, 0x64, 0x74, 0x32, 0x64, 0x64, 0x74, 0x64 },
                offset = 0,
                extention = "dtd",
                description = "DesignTools 2D Design file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x0A, 0x00, 0x01 },
                offset = 0,
                extention = "pcx",
                description = "ZSOFT Paintbrush file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x0A, 0x01, 0x01 },
                offset = 0,
                extention = "pcx",
                description = "ZSOFT Paintbrush file (v1)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x0A, 0x02, 0x01 },
                offset = 0,
                extention = "pcx",
                description = "ZSOFT Paintbrush file (v2)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x0A, 0x03, 0x01 },
                offset = 0,
                extention = "pcx",
                description = "ZSOFT Paintbrush file (v3)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x0A, 0x04, 0x01 },
                offset = 0,
                extention = "pcx",
                description = "ZSOFT Paintbrush file (v4)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x0A, 0x05, 0x01 },
                offset = 0,
                extention = "pcx",
                description = "ZSOFT Paintbrush file (v5)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x0A, 0x16, 0x6F, 0x72, 0x67, 0x2E, 0x62, 0x69, 0x74, 0x63, 0x6F, 0x69, 0x6E, 0x2E, 0x70, 0x72 },
                offset = 0,
                extention = "wallet",
                description = "MultiBit Bitcoin wallet file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x0D, 0x44, 0x4F, 0x43 },
                offset = 0,
                extention = "doc",
                description = "DeskMate Document file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x0E, 0x4E, 0x65, 0x72, 0x6F, 0x49, 0x53, 0x4F },
                offset = 0,
                extention = "NeroISO",
                description = "Nero CD Compilation"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x0E, 0x57, 0x4B, 0x53 },
                offset = 0,
                extention = "wks",
                description = "DeskMate Worksheet"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x10, 0x00, 0x00, 0x00 },
                offset = 0,
                extention = "cl5",
                description = "Easy CD Creator 5 Layout file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x1A, 0x00, 0x00 },
                offset = 0,
                extention = "ntf",
                description = "Lotus Notes database template"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x1A, 0x00, 0x00, 0x04, 0x00, 0x00 },
                offset = 0,
                extention = "nsf",
                description = "Lotus Notes database"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x1A, 0x02 },
                offset = 0,
                extention = "arc",
                description = "LH archive file (type 1)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x1A, 0x03 },
                offset = 0,
                extention = "arc",
                description = "LH archive file (type 2)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x1A, 0x04 },
                offset = 0,
                extention = "arc",
                description = "LH archive file (type 3)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x1A, 0x08 },
                offset = 0,
                extention = "arc",
                description = "LH archive file (type 4)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x1A, 0x09 },
                offset = 0,
                extention = "arc",
                description = "LH archive file (type 5)"
            });
            
            SignList.Add(new Sign() {
                signature = new byte[] { 0x1A, 0x0B },
                offset = 0,
                extention = "pak",
                description = "Compressed archive file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x1A, 0x35, 0x01, 0x00 },
                offset = 0,
                extention = "eth",
                description = "GN Nettest WinPharoah capture file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x1A, 0x45, 0xDF, 0xA3 },
                offset = 0,
                extention = "mkv, webm",
                description = "Matroska stream file, WebM video file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x1A, 0x52, 0x54, 0x53, 0x20, 0x43, 0x4F, 0x4D, 0x50, 0x52, 0x45, 0x53, 0x53, 0x45, 0x44, 0x20, 0x49, 0x4D, 0x41, 0x47, 0x45, 0x20, 0x56, 0x31, 0x2E, 0x30, 0x1A },
                offset = 0,
                extention = "dat",
                description = "Runtime Software compressed disk image"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x1D, 0x7D },
                offset = 0,
                extention = "ws",
                description = "WordStar Version 5.0/6.0 document"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x1F, 0x8B, 0x08 },
                offset = 0,
                extention = "gz, tgz, vlt",
                description = "GZIP archive file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x1F, 0x9D },
                offset = 0,
                extention = "tar.z",
                description = "Compressed tape archive file using standard (Lempel-Ziv-Welch) compression"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x1F, 0xA0 },
                offset = 0,
                extention = "tar.z",
                description = "Compressed tape archive file using LZH (Lempel-Ziv-Huffman) compression"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x21, 0x12 },
                offset = 0,
                extention = "ain",
                description = "AIN Compressed Archive"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x21, 0x3C, 0x61, 0x72, 0x63, 0x68, 0x3E, 0x0A },
                offset = 0,
                extention = "lib",
                description = "Unix archiver (ar) files and Microsoft Program Library Common Object File Format(COFF)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x21, 0x42, 0x44, 0x4E }, //!BDN
                offset = 0,
                extention = "ost, pab, pst",
                description = "Microsoft Outlook Folder/File"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x23, 0x20, 0x44, 0x69, 0x73, 0x6B, 0x20, 0x44, 0x65, 0x73, 0x63, 0x72, 0x69, 0x70, 0x74, 0x6F }, //# Disk Descripto
                offset = 0,
                extention = "vmdk",
                description = "VMware 4 Virtual Disk description file (split disk)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x23, 0x20, 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x44, 0x65, 0x76, 0x65, 0x6C, 0x6F, 0x70, 0x65, 0x72, 0x20, 0x53, 0x74, 0x75, 0x64, 0x69, 0x6F },
                offset = 0,
                extention = "dsp",
                description = "Microsoft Developer Studio project file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x23, 0x21, 0x41, 0x4D, 0x52 }, //#!AMR
                offset = 0,
                extention = "amr",
                description = "Adaptive Multi-Rate ACELP"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x23, 0x21, 0x53, 0x49, 0x4C, 0x4B, 0x0A }, //#!SILK.
                offset = 0,
                extention = "sil",
                description = "Audio compression format (Skype)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x23, 0x3F, 0x52, 0x41, 0x44, 0x49, 0x41, 0x4E, 0x43, 0x45, 0x0A }, //#?RADIANCE.
                offset = 0,
                extention = "hdr",
                description = "Radiance High Dynamic Range image file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x23, 0x50, 0x45, 0x43, 0x30, 0x30, 0x30, 0x31, 0x4C, 0x41, 0x3A }, //#PEC0001LA:
                offset = 0,
                extention = "pec",
                description = "Brother/Babylock/Bernina Home Embroidery file"
            });

            SignList.Add(new Sign() { //#PES0
                signature = new byte[] { 0x23, 0x50, 0x45, 0x53, 0x30 },
                offset = 0,
                extention = "pes",
                description = "Brother/Babylock/Bernina Home Embroidery file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x24, 0x46, 0x4C, 0x32, 0x40, 0x28, 0x23, 0x29, 0x20, 0x53, 0x50, 0x53, 0x53, 0x20, 0x44, 0x41, 0x54, 0x41, 0x20, 0x46, 0x49, 0x4C, 0x45 },
                offset = 0,
                extention = "sav",
                description = "SPSS Data file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x25, 0x21, 0x50, 0x53, 0x2D, 0x41, 0x64, 0x6F, 0x62, 0x65, 0x2D, 0x33, 0x2E, 0x30, 0x20, 0x45, 0x50, 0x53, 0x46, 0x2D, 0x33, 0x20, 0x30 },
                offset = 0,
                extention = "eps",
                description = "Adobe encapsulated PostScript file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x25, 0x50, 0x44, 0x46 },
                offset = 0,
                extention = "pdf, fdf, ai",
                description = "Adobe Portable Document Format, Forms Document Format, and Illustrator graphics files"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x25, 0x62, 0x69, 0x74, 0x6D, 0x61, 0x70 }, //%bitmap
                offset = 0,
                extention = "fbm",
                description = "Fuzzy bitmap file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x2D, 0x6C, 0x68 },
                offset = 2,
                extention = "lha, lzh",
                description = "Compressed archive file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x2E, 0x52, 0x45, 0x43 },
                offset = 0,
                extention = "ivr",
                description = "RealPlayer video file (V11 and later)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x2E, 0x52, 0x4D, 0x46 },
                offset = 0,
                extention = "rm, rmvb",
                description = "RealMedia streaming media file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x2E, 0x52, 0x4D, 0x46, 0x00, 0x00, 0x00, 0x12, 0x00},
                offset = 0,
                extention = "ra",
                description = "	RealAudio file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x2E, 0x72, 0x61, 0xFD, 0x00 },
                offset = 0,
                extention = "ra",
                description = "RealAudio streaming media file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x2E, 0x73, 0x6E, 0x64 },
                offset = 0,
                extention = "au",
                description = "NeXT/Sun Microsystems µ-Law audio file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x2F, 0x2F, 0x20, 0x3C, 0x21, 0x2D, 0x2D, 0x20, 0x3C, 0x6D, 0x64, 0x62, 0x3A, 0x6D, 0x6F, 0x72, 0x6B, 0x3A, 0x7A },
                offset = 0,
                extention = "msf",
                description = "Thunderbird/Mozilla Mail Summary File"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x30, 0x00, 0x00, 0x00, 0x4C, 0x66, 0x4C, 0x65 },
                offset = 0,
                extention = "evt",
                description = "Windows Event Viewer file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x30, 0x20, 0x48, 0x45, 0x41, 0x44 },
                offset = 0,
                extention = "ged",
                description = "GEnealogical Data COMmunication (GEDCOM) file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x30, 0x26, 0xB2, 0x75, 0x8E, 0x66, 0xCF, 0x11, 0xA6, 0xD9, 0x00, 0xAA, 0x00, 0x62, 0xCE, 0x6C },
                offset = 0,
                extention = "asf, wma, amv",
                description = "Microsoft Windows Media Audio/Video File"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x30, 0x31, 0x4F, 0x52, 0x44, 0x4E, 0x41, 0x4E, 0x43, 0x45, 0x20, 0x53, 0x55, 0x52, 0x56, 0x45, 0x59, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20},
                offset = 0,
                extention = "ntf",
                description = "National Transfer Format Map File"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x31, 0xBE },
                offset = 0,
                extention = "wri",
                description = "Microsoft Write file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x32, 0xBE },
                offset = 0,
                extention = "wri",
                description = "Microsoft Write file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x32, 0x03, 0x10, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80, 0x00, 0x00, 0x00, 0xFF, 0x00 },
                offset = 0,
                extention = "pcs",
                description = "Pfaff Home Embroidery file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x34, 0xCD, 0xB2, 0xA1 },
                offset = 0,
                extention = null,
                description = "Extended tcpdump (libpcap) capture file (Linux/Unix)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x37, 0x7A, 0xBC, 0xAF, 27, 0x1C },
                offset = 0,
                extention = "7z",
                description = "7-Zip compressed file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x37, 0xE4, 0x53, 0x96, 0xC9, 0xDB, 0xD6, 0x07 },
                offset = 0,
                extention = null,
                description = "Zisofs compression format, recognized by some Linux kernels."
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x38, 0x42, 0x50, 0x53 },
                offset = 0,
                extention = "psd",
                description = "Photoshop image file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x3A, 0x56, 0x45, 0x52, 0x53, 0x49, 0x4F, 0x4E },
                offset = 0,
                extention = "sle",
                description = "Surfplan kite project file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("<!doctyp"),
                offset = 0,
                extention = "dci",
                description = "AOL HTML mail file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("<?xml version = "),
                offset = 0,
                extention = "manifest",
                description = "Windows Visual Stylesheet XML file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("<?xml version = \"1.0\"?>"),
                offset = 0,
                extention = "XML User Interface Language file",
                description = "xul"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("<CTransTimeline>"),
                offset = 0,
                extention = "mxf",
                description = "Picasa movie project file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("<CsoundSynthesiz"),
                offset = 0,
                extention = "csd",
                description = "Csound music file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("<MakerFile"),
                offset = 0,
                extention = "fm, mif",
                description = "Adobe FrameMaker file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("<gpx version=\"1.1"),
                offset = 0,
                extention = "gpx",
                description = "	GPS eXchange file (v1.1 schema)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x3C, 0x7E, 0x36, 0x3C, 0x5C, 0x25, 0x5F, 0x30, 0x67, 0x53, 0x71, 0x68, 0x3B },
                offset = 0,
                extention = "b85",
                description = "ASCII85 (aka BASE85) encoded file, sometimes used with PostScript and PDF."
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x3E, 0x00, 0x03, 0x00, 0xFE, 0xFF, 0x09, 0x00, 0x06 },
                offset = 24,
                extention = "wb3",
                description = "Quatro Pro for Windows 7.0 Notebook file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x3F, 0x5F, 0x03, 0x00 },
                offset = 0,
                extention = "gid, hlp",
                description = "Windows Help file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x40, 0x40, 0x40, 0x20, 0x00, 0x00, 0x40, 0x40, 0x40, 0x40},
                offset = 0,
                extention = "enl",
                description = "EndNote Library File"
            });
            
            SignList.Add(new Sign() {
                signature = new byte[] { 0x41, 0x43, 0x31, 0x2E, 0x32 },
                offset = 0,
                extention = "dwg",
                description = "AutoCAD drawing file v1.2"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x41, 0x43, 0x31, 0x2E, 0x33 },
                offset = 0,
                extention = "dwg",
                description = "AutoCAD drawing file v1.3"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x41, 0x43, 0x31, 0x2E, 0x34, 0x30 },
                offset = 0,
                extention = "dwg",
                description = "AutoCAD drawing file v1.4"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x41, 0x43, 0x31, 0x2E, 0x35, 0x30 },
                offset = 0,
                extention = "dwg",
                description = "AutoCAD drawing file v2.05"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x41, 0x43, 0x31, 0x2E, 0x31, 0x30 },
                offset = 0,
                extention = "dwg",
                description = "AutoCAD drawing file v2.10"
            });



            SignList.Add(new Sign() {
                signature = new byte[] { 0x41, 0x43, 0x31, 0x30, 0x30, 0x32 },
                offset = 0,
                extention = "dwg",
                description = "AutoCAD drawing file v2.5"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x41, 0x43, 0x31, 0x30, 0x30, 0x33 },
                offset = 0,
                extention = "dwg",
                description = "AutoCAD drawing file v2.6"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x41, 0x43, 0x31, 0x30, 0x30, 0x34 },
                offset = 0,
                extention = "dwg",
                description = "AutoCAD drawing file v9"
            });
            SignList.Add(new Sign() {
                signature = new byte[] { 0x41, 0x43, 0x31, 0x30, 0x30, 0x36 },
                offset = 0,
                extention = "dwg",
                description = "AutoCAD drawing file v10"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x41, 0x43, 0x31, 0x30, 0x30, 0x39 },
                offset = 0,
                extention = "dwg",
                description = "AutoCAD drawing file v11/v12"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x41, 0x43, 0x31, 0x30, 0x31, 0x32 },
                offset = 0,
                extention = "dwg",
                description = "AutoCAD drawing file v13"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x41, 0x43, 0x31, 0x30, 0x31, 0x34 },
                offset = 0,
                extention = "dwg",
                description = "AutoCAD drawing file v14"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x41, 0x43, 0x31, 0x30, 0x31, 0x35 },
                offset = 0,
                extention = "dwg",
                description = "AutoCAD drawing file v15"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x41, 0x43, 0x31, 0x30, 0x31, 0x38 },
                offset = 0,
                extention = "dwg",
                description = "AutoCAD drawing file v16"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x41, 0x43, 0x31, 0x30, 0x32, 0x31 },
                offset = 0,
                extention = "dwg",
                description = "AutoCAD drawing file v17"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x41, 0x43, 0x31, 0x30, 0x32, 0x34 },
                offset = 0,
                extention = "dwg",
                description = "AutoCAD drawing file 18"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x41, 0x43, 0x31, 0x30, 0x32, 0x37 },
                offset = 0,
                extention = "dwg",
                description = "AutoCAD drawing file v19"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x41, 0x43, 0x31, 0x30, 0x33, 0x32 },
                offset = 0,
                extention = "dwg",
                description = "AutoCAD drawing file v22"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x41, 0x43, 0x76 }, //ACL
                offset = 0,
                extention = "sle",
                description = "Steganos Security Suite virtual secure drive"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x41, 0x43, 0x53, 0x44 }, //ACSD
                offset = 0,
                extention = null,
                description = "Miscellaneous AOL parameter and information files"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x41, 0x45, 0x53 }, //AES
                offset = 0,
                extention = "aes",
                description = "AES Crypt file format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x41, 0x4D, 0x59, 0x4F }, //AMYO
                offset = 0,
                extention = "syq",
                description = "Harvard Graphics symbol graphic"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x41, 0x4F, 0x4C, 0x20, 0x46, 0x65, 0x65, 0x64, 0x62, 0x61, 0x67 }, //AOL Feedbag
                offset = 0,
                extention = "bag",
                description = "AOL and AIM buddy list file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x41, 0x4F, 0x4C, 0x44, 0x42 }, //AOLDB
                offset = 0,
                extention = "aby, idx",
                description = "AOL database files: address book (ABY) and user configuration data(MAIN.IDX)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x41, 0x4F, 0x4C, 0x49, 0x44, 0x58 }, //AOLIDX
                offset = 0,
                extention = "ind",
                description = "AOL client preferences/settings file"
            });

            SignList.Add(new Sign() { 
                signature = new byte[] { 0x41, 0x4F, 0x4C, 0x49, 0x4E, 0x44, 0x45, 0x58 }, //AOLINDEX
                offset = 0,
                extention = "abi",
                description = "AOL address book index file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x41, 0x4F, 0x4C, 0x56, 0x4D, 0x31, 0x30, 0x30 }, //AOLVM100
                offset = 0,
                extention = "org, pfc",
                description = "AOL personal file cabinet (PFC) file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x41, 0x56, 0x47, 0x36, 0x5F, 0x49, 0x6E, 0x74, 0x65, 0x67, 0x72, 0x69, 0x74, 0x79, 0x5F, 0x44, 0x61, 0x74, 0x61, 0x62, 0x61, 0x73, 0x65 },
                offset = 0,
                extention = "dat",
                description = "AVG6 Integrity database file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x41, 0x72, 0x43, 0x01 }, //ArC.
                offset = 0,
                extention = "arc",
                description = "FreeArc compressed file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x42, 0x41, 0x41, 0x44 }, //BAAD
                offset = 0,
                extention = null,
                description = "NTFS Master File Table (MFT) entry (1,024 bytes)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x42, 0x45, 0x47, 0x49, 0x4E, 0x3A, 0x56, 0x43, 0x41, 0x52, 0x44, 0x0D, 0x0A },
                offset = 0,
                extention = "vCard file",
                description = "vcf"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x42, 0x4C, 0x49, 0x32, 0x32, 0x33 }, //BLI223
                offset = 0,
                extention = "bli, rbi",
                description = "Thomson Speedtouch series WLAN router firmware"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x42, 0x4F, 0x4F, 0x4B, 0x4D, 0x4F, 0x42, 0x49 }, //BOOKMOBI
                offset = 0,
                extention = "prc",
                description = "Palmpilot resource file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x42, 0x50, 0x47, 0xFB }, //BPG#xFB;
                offset = 0,
                extention = "bpg",
                description = "Better Portable Graphics image format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x43, 0x23, 0x2B, 0x44, 0xA4, 0x43, 0x4D, 0xA5, 0x48, 0x64, 0x72 },
                offset = 0,
                extention = "rtd",
                description = "RagTime document file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x43, 0x41, 0x54, 0x20 },
                offset = 0,
                extention = "iff",
                description = "Electronic Arts' Interchange Format Files (IFF) format."
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x43, 0x49, 0x53, 0x4F }, //CISO
                offset = 0,
                extention = "cso",
                description = "Compressed ISO (CISO) CD image"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x43, 0x4D, 0x4D, 0x4D, 0x15, 0x00, 0x00, 0x00 },
                offset = 0,
                extention = "db",
                description = "Windows 7 thumbcache_sr.db or other thumbcache file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x43, 0x4D, 0x58, 0x31 }, //CMX1
                offset = 0,
                extention = "clb",
                description = "Corel Binary metafile"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x43, 0x4F, 0x4D, 0x2B }, //COM+
                offset = 0,
                extention = "clb",
                description = "COM+ Catalog file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x43, 0x4F, 0x57, 0x44 }, //COWD
                offset = 0,
                extention = "vmdk",
                description = "VMware 3 Virtual Disk (portion of a split disk) file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x43, 0x50, 0x54, 0x37, 0x46, 0x49, 0x4C, 0x45 }, //CPT7FILE
                offset = 0,
                extention = "cpt",
                description = "Corel Photopaint file"
            });


            SignList.Add(new Sign() {
                signature = new byte[] { 0x43, 0x50, 0x54, 0x46, 0x49, 0x4C, 0x45 }, //CPTFILE
                offset = 0,
                extention = "cpt",
                description = "Corel Photopaint file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x43, 0x52, 0x45, 0x47 }, //CREG
                offset = 0,
                extention = "dat",
                description = "Windows 9x registry hive"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x43, 0x52, 0x55, 0x53, 0x48, 0x20, 0x76 }, //CRUSH v
                offset = 0,
                extention = "cru",
                description = "Crush compressed archive"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x43, 0x57, 0x53 }, //CWS
                offset = 0,
                extention = "swf",
                description = "Macromedia Shockwave Flash player file (zlib compressed, SWF 6 and later)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x43, 0x61, 0x6C, 0x63, 0x75, 0x6C, 0x75, 0x78, 0x20, 0x49, 0x6E, 0x64, 0x6F, 0x6F, 0x72, 0x20 },
                offset = 0,
                extention = "cin",
                description = "Calculux Indoor lighting design software project file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x43, 0x61, 0x74, 0x61, 0x6C, 0x6F, 0x67, 0x20, 0x33, 0x2E, 0x30, 0x30, 0x00 },
                offset = 0,
                extention = "ctf",
                description = "WhereIsIt Catalog file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x43, 0x6C, 0x69, 0x65, 0x6E, 0x74, 0x20, 0x55, 0x72, 0x6C, 0x43, 0x61, 0x63, 0x68, 0x65, 0x20, 0x4D, 0x4D, 0x46, 0x20, 0x56, 0x65, 0x72, 0x20 },
                offset = 0,
                extention = "dat",
                description = "Microsoft Internet Explorer cache file (index.dat) file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x43, 0x72, 0x65, 0x61, 0x74, 0x69, 0x76, 0x65, 0x20, 0x56, 0x6F, 0x69, 0x63, 0x65, 0x20, 0x46 }, //Creative Voice F
                offset = 0,
                extention = "voc",
                description = "Creative Voice audio file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x44, 0x41, 0x58, 0x00 },
                offset = 0,
                extention = "dax",
                description = "DAX Compressed CD image"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x44, 0x42, 0x46, 0x48 }, //DBFH
                offset = 0,
                extention = "db",
                description = "Palm Zire photo database"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x44, 0x4D, 0x53, 0x21 }, //DMS!
                offset = 0,
                extention = "dms",
                description = "Amiga DiskMasher compressed archive"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x44, 0x4F, 0x53 }, //DOS
                offset = 0,
                extention = "adf",
                description = "Amiga disk file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x44, 0x53, 0x44, 0x20 },
                offset = 0,
                extention = "dsf",
                description = "DSD Storage Facility audio file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x44, 0x53, 0x54, 0x62 }, //DSTb
                offset = 0,
                extention = "dst",
                description = "DST compressed file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x44, 0x56, 0x44 }, //DVD
                offset = 0,
                extention = "ifo",
                description = "	DVD info file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x45, 0x4C, 0x49, 0x54, 0x45, 0x20, 0x43, 0x6F, 0x6D, 0x6D, 0x61, 0x6E, 0x64, 0x65, 0x72, 0x20 }, //ELITE Commander
                offset = 0,
                extention = "cdr",
                description = "Elite Plus Commander saved game file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x45, 0x4E, 0x54, 0x52, 0x59, 0x56, 0x43, 0x44, 0x02, 0x00, 0x00, 0x01, 0x02, 0x00, 0x18, 0x58 },
                offset = 0,
                extention = "vcd",
                description = "VideoVCD (GNU VCDImager) file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x45, 0x52, 0x46, 0x53, 0x53, 0x41, 0x56, 0x45, 0x44, 0x41, 0x54, 0x41, 0x46, 0x49, 0x4C, 0x45 },
                offset = 0,
                extention = "dat",
                description = "Kroll EasyRecovery Saved Recovery State file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x45, 0x50 }, //EP
                offset = 0,
                extention = "mdi",
                description = "Microsoft Document Imaging file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x45, 0x6C, 0x66, 0x46, 0x69, 0x6C, 0x65, 0x00 },
                offset = 0,
                extention = "evtx",
                description = "Windows Vista event log file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x45, 0x86, 0x00, 0x00, 0x06, 0x00 },
                offset = 0,
                extention = "qbb",
                description = "Intuit QuickBooks backup file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x46, 0x41, 0x58, 0x43, 0x4F, 0x56, 0x45, 0x52, 0x2D, 0x56, 0x45, 0x52 }, //FAXCOVER-VER
                offset = 0,
                extention = "cpe",
                description = "Microsoft Fax Cover Sheet"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x46, 0x44, 0x42, 0x48, 0x00 },
                offset = 0,
                extention = "fdb",
                description = "Fiasco database definition file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x46, 0x49, 0x4C, 0x45 }, //FILE
                offset = 0,
                extention = null,
                description = "NTFS Master File Table (MFT) entry (1,024 bytes)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x46, 0x4C, 0x56, 0x01 },
                offset = 0,
                extention = "flv",
                description = "Flash video file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x46, 0x57, 0x53 }, //FWS
                offset = 0,
                extention = "swf",
                description = "Macromedia Shockwave Flash player file (uncompressed)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x46, 0x72, 0x6F, 0x6D, 0x20, 0x20, 0x20 },
                offset = 0,
                extention = "eml",
                description = "Commmon e-mail files (Netscape)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x46, 0x72, 0x6F, 0x6D, 0x20, 0x3F, 0x3F, 0x3F },
                offset = 0,
                extention = "eml",
                description = "Commmon e-mail files (Eudora)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x46, 0x72, 0x6F, 0x6D, 0x3A, 0x20 },
                offset = 0,
                extention = "eml",
                description = "Commmon e-mail files (generic signature)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x47, 0x46, 0x31, 0x50, 0x41, 0x54, 0x43, 0x48 }, //GF1PATCH
                offset = 0,
                extention = "pat",
                description = "Advanced Gravis Ultrasound patch file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x47, 0x49, 0x46, 0x38, 0x37, 0x61 },
                offset = 0,
                extention = "gif",
                description = "Graphics interchange format file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x47, 0x49, 0x46, 0x38, 0x39, 0x61 },
                offset = 0,
                extention = "gif",
                description = "Graphics interchange format file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x47, 0x50, 0x41, 0x54 }, //GPAT
                offset = 0,
                extention = "pat",
                description = "GIMP (GNU Image Manipulation Program) pattern file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x47, 0x52, 0x49, 0x42 }, //GRIB
                offset = 0,
                extention = "grb",
                description = "GRIdded Binary or General Regularly-distributed Information in Binary file, commonly used in meteorology to store historical and forecast weather data"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x47, 0x65, 0x6E, 0x65, 0x74, 0x65, 0x63, 0x20, 0x4F, 0x6D, 0x6E, 0x69, 0x63, 0x61, 0x73, 0x74 }, //Genetec Omnicast
                offset = 0,
                extention = "g64",
                description = "Genetec video archive"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x48, 0x45, 0x41, 0x44, 0x45, 0x52, 0x20, 0x52, 0x45, 0x43, 0x4F, 0x52, 0x44, 0x2A, 0x2A, 0x2A }, //HEADER RECORD***
                offset = 0,
                extention = "xpt",
                description = "SAS Transport dataset file format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x48, 0x48, 0x47, 0x42, 0x31 },
                offset = 0,
                extention = "sh3",
                description = "Harvard Graphics presentation file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x49, 0x20, 0x49 },
                offset = 0,
                extention = "tif, tiff",
                description = "Tagged Image File Format file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x49, 0x44, 0x33, 0x03, 0x00, 0x00, 0x00 },
                offset = 0,
                extention = "koz",
                description = "Sprint Music Store audio file (for mobile devices)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x49, 0x49, 0x1A, 0x00, 0x00, 0x00, 0x48, 0x45, 0x41, 0x50, 0x43, 0x43, 0x44, 0x52, 0x02, 0x00 },
                offset = 0,
                extention = "crw",
                description = "Canon digital camera RAW file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x49, 0x49, 0x2A, 0x00, 0x10, 0x00, 0x00, 0x00, 0x43, 0x52 },
                offset = 0,
                extention = "cr2",
                description = "Canon digital camera RAW file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x49, 0x4D, 0x4D, 0x4D, 0x15, 0x00, 0x00, 0x00 },
                offset = 0,
                extention = "db",
                description = "Windows 7 thumbcache_idx.db file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x49, 0x53, 0x63, 0x28 },
                offset = 0,
                extention = "cab, hdr",
                description = "Install Shield v5.x or 6.x compressed file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x49, 0x54, 0x4F, 0x4C, 0x49, 0x54, 0x4C, 0x53 }, //ITOLITLS
                offset = 0,
                extention = "lit",
                description = "Microsoft Reader eBook file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x49, 0x54, 0x53, 0x46 }, //ITSF
                offset = 0,
                extention = "chi, chm",
                description = "Microsoft Compiled HTML Help File"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x49, 0x6E, 0x6E, 0x6F, 0x20, 0x53, 0x65, 0x74, 0x75, 0x70, 0x20, 0x55, 0x6E, 0x69, 0x6E, 0x73, 0x74, 0x61, 0x6C, 0x6C, 0x20, 0x4C, 0x6F, 0x67, 0x20, 0x28, 0x62, 0x29 },
                offset = 0,
                extention = "dat",
                description = "Inno Setup Uninstall Log file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x49, 0x6E, 0x74, 0x65, 0x72, 0x40, 0x63, 0x74, 0x69, 0x76, 0x65, 0x20, 0x50, 0x61, 0x67, 0x65 }, //Inter@ctive Page
                offset = 0,
                extention = "ipd",
                description = "Inter@ctive Pager Backup (BlackBerry) backup file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4A, 0x41, 0x52, 0x43, 0x53, 0x00 },
                offset = 0,
                extention = "jar",
                description = "JARCS compressed archive"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4B, 0x44, 0x4D },
                offset = 0,
                extention = "vmdk",
                description = "VMware 4 Virtual Disk (portion of a split disk) file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4B, 0x44, 0x4D, 0x56 },
                offset = 0,
                extention = "vmdk",
                description = "VMware 4 Virtual Disk (monolitic disk) file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4B, 0x47, 0x42, 0x5F, 0x61, 0x72, 0x63, 0x68, 0x20, 0x2D },
                offset = 0,
                extention = "kgb",
                description = "KGB archive"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4B, 0x49, 0x00, 0x00 },
                offset = 0,
                extention = "shd",
                description = "Windows 9x printer spool file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4C, 0x00, 0x00, 0x00, 0x01, 0x14, 0x02, 0x00 },
                offset = 0,
                extention = "lnk",
                description = "	Windows shell link (shortcut) file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4C, 0x41, 0x3A },
                offset = 0,
                extention = "dst",
                description = "Tajima embroidery sticj image file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4C, 0x49, 0x53, 0x54 }, //LIST
                offset = 0,
                extention = "iff",
                description = "Electronic Arts' Interchange Format Files (IFF) format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4C, 0x50, 0x46, 0x20, 0x00, 0x01 },
                offset = 0,
                extention = "anm",
                description = "DeluxePaint Animation file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4C, 0x4E, 0x02, 0x00 },
                offset = 0,
                extention = "gid, hlp",
                description = "Windows Help file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4D, 0x2D, 0x57, 0x20, 0x50, 0x6F, 0x63, 0x6B, 0x65, 0x74, 0x20, 0x44, 0x69, 0x63, 0x74, 0x69 }, //M-W Pocket Dicti
                offset = 0,
                extention = "pdb",
                description = "Merriam-Webster Pocket Dictionary file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4D, 0x41, 0x52, 0x31, 0x00 },
                offset = 0,
                extention = "mar",
                description = "Mozilla archive"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4D, 0x41, 0x52, 0x43 },
                offset = 0,
                extention = "mar",
                description = "Microsoft/MSN MARC archive"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4D, 0x41, 0x54, 0x4C, 0x41, 0x42, 0x20, 0x35, 0x2E, 0x30, 0x20, 0x4D, 0x41, 0x54, 0x2D, 0x66, 0x69, 0x6C, 0x65},
                offset = 0,
                extention = "mat",
                description = "MATLAB v5 workspace file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4D, 0x41, 0x72, 0x30, 0x00 },
                offset = 0,
                extention = "mar",
                description = "MAr compressed archive"
            });

            SignList.Add(new Sign() { //MCW Technogolies
                signature = new byte[] { 0x4D, 0x43, 0x57, 0x20, 0x54, 0x65, 0x63, 0x68, 0x6E, 0x6F, 0x67, 0x6F, 0x6C, 0x69, 0x65, 0x73 },
                offset = 0,
                extention = "mte",
                description = "TargetExpress target file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4D, 0x44, 0x4D, 0x50, 0x93, 0xA7 },
                offset = 0,
                extention = "hdmp, dmp",
                description = "Windows heap dump/minidump file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4D, 0x49, 0x4C, 0x45, 0x53 },
                offset = 0,
                extention = "mls",
                description = "Milestones v1.0 project management and scheduling software"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4D, 0x4C, 0x53, 0x57 },
                offset = 0,
                extention = "mls",
                description = "Skype localization data file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4D, 0x4D, 0x4D, 0x44, 0x00, 0x00 },
                offset = 0,
                extention = "mmf",
                description = "Yamaha Corp. Synthetic music Mobile Application Format (SMAF) for multimedia files that can be played on hand - held devices."
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4D, 0x52, 0x56, 0x4E }, //MRVN
                offset = 0,
                extention = "nvram",
                description = "VMware BIOS (non-volatile RAM) state file."
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4D, 0x53, 0x46, 0x54, 0x02, 0x00, 0x01, 0x00 },
                offset = 0,
                extention = "tlb",
                description = "OLE, SPSS, or Visual C++ type library file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4D, 0x53, 0x57, 0x49, 0x4D }, //MSWIM
                offset = 0,
                extention = "wim",
                description = "Microsoft Windows Imaging Format file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4D, 0x53, 0x5F, 0x56, 0x4F, 0x49, 0x43, 0x45 },
                offset = 0,
                extention = "cdr, dvf, msv",
                description = "Sony Compressed Voice file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4D, 0x56 }, //MV
                offset = 0,
                extention = "dsn",
                description = "CD Stomper Pro label file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4D, 0x56, 0x32, 0x31, 0x34 }, //MV214
                offset = 0,
                extention = "mls",
                description = "Milestones v2.1b project management and scheduling software"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4D, 0x56, 0x32, 0x43 },
                offset = 0,
                extention = "mls",
                description = "Milestones v2.1a project management and scheduling software"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4D, 0x5A, 0x90, 0x00, 0x03, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0xFF, 0xFF},
                offset = 0,
                extention = "zap",
                description = "ZoneAlam data file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("Microsoft C/C++"),
                offset = 0,
                extention = "pdb",
                description = "Microsoft C++ debugging symbols file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("Microsoft Visual Studio Solution File"),
                offset = 0,
                extention = "sln",
                description = "Visual Studio .NET Solution file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("Microsoft Windows Media Player --"),
                offset = 84,
                extention = "wpl",
                description = "Windows Media Player playlist"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("MsRcf"),
                offset = 0,
                extention = "gdb",
                description = "VMapSource GPS Waypoint Database"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("NAVTRAFFIC"),
                offset = 0,
                extention = "dat",
                description = "TomTom traffic data file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4E, 0x42, 0x2A, 0x00 },
                offset = 0,
                extention = "jnt, jtp",
                description = "MS Windows journal file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4E, 0x45, 0x53, 0x4D, 0x1A, 0x01 },
                offset = 0,
                extention = "nsf",
                description = "NES Sound file"
            });

            SignList.Add(new Sign() { //NITF0
                signature = new byte[] { 0x4E, 0x49, 0x54, 0x46, 0x30 },
                offset = 0,
                extention = "ntf",
                description = "National Imagery Transmission Format (NITF) file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("OPCLDAT"),
                offset = 0,
                extention = "attachment",
                description = "1Password 4 Cloud Keychain encrypted attachment"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("OPLDatabaseFile"),
                offset = 0,
                extention = "dbf",
                description = "Psion Series 3 Database file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4F, 0x54, 0x54, 0x4F, 0x00 },
                offset = 0,
                extention = "otf",
                description = "OpenType font file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x4F, 0x67, 0x67, 0x53, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 },
                offset = 0,
                extention = "oga, ogg, ogv, ogx",
                description = "Ogg Vorbis Codec compressed Multimedia file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x50, 0x00, 0x00, 0x00, 0x20, 0x00, 0x00, 0x00 },
                offset = 0,
                extention = "idx",
                description = "Quicken QuickFinder Information File"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x50, 0x35, 0x0A },
                offset = 0,
                extention = "pgm",
                description = "Portable Graymap Graphic"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("PAGEDU64"),
                offset = 0,
                extention = "dmp",
                description = "Windows 64-bit memory dump"
            });
            
            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("PAGEDUMP"),
                offset = 0,
                extention = "dmp",
                description = "Windows memory dump"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("PAX"),
                offset = 0,
                extention = "pax",
                description = "PAX password protected bitmap"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("PEST"),
                offset = 0,
                extention = "dat",
                description = "PestPatrol data/scan strings"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("PGPdMAIN"),
                offset = 0,
                extention = "pgd",
                description = "PGP disk image"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x50, 0x49, 0x43, 0x54, 0x00, 0x08 },
                offset = 0,
                extention = "img",
                description = "ADEX Corp. ChromaGraph Graphics Card Bitmap Graphic file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x50, 0x4B, 0x03, 0x04, 0x0A, 0x00, 0x02, 0x00 },
                offset = 0,
                extention = "epub",
                description = "Open Publication Structure eBook file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x50, 0x4B, 0x03, 0x04, 0x14, 0x00, 0x01, 0x00, 0x63, 0x00, 0x00, 0x00, 0x00, 0x00 },
                offset = 0,
                extention = "zip",
                description = "ZLock Pro encrypted ZIP"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x50, 0x4B, 0x03, 0x04, 0x14, 0x00, 0x06, 0x00 },
                offset = 0,
                extention = "docx, pptx, xlsx",
                description = "Microsoft Office Open XML Format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x50, 0x4B, 0x03, 0x04, 0x14, 0x00, 0x08, 0x00, 0x08, 0x00},
                offset = 0,
                extention = "jar",
                description = "Java archive"
            });


            SignList.Add(new Sign() {
                signature = new byte[] { 0x50, 0x4B, 0x4C, 0x49, 0x54, 0x45 },
                offset = 30,
                extention = "zip",
                description = "PKLITE compressed ZIP archive"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x50, 0x4B, 0x53, 0x70, 0x58 },
                offset = 526,
                extention = "zip",
                description = "PKSFX self-extracting executable compressed file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x50, 0x4D, 0x43, 0x43 },
                offset = 0,
                extention = "grp",
                description = "Windows Program Manager group file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("PNCIUNDO"),
                offset = 0,
                extention = "dat",
                description = "Norton Disk Doctor undo file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("PMOCCMOC"),
                offset = 0,
                extention = "dat",
                description = "Microsoft® Windows® User State Migration Tool (USMT)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x50, 0x53, 0x46, 0x12 },
                offset = 0,
                extention = "dsf",
                description = "Dreamcast Sound Format file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x50, 0x55, 0x46, 0x58 },
                offset = 0,
                extention = "puf",
                description = "Puffer encrypted archive"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x50, 0x61, 0x56, 0x45 },
                offset = 0,
                extention = null,
                description = "Parrot Video Encapsulation file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x51, 0x45, 0x4C, 0x20 },
                offset = 92,
                extention = "qel",
                description = "Quicken data file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x51, 0x46, 0x49, 0xFB },
                offset = 0,
                extention = "img",
                description = "QEMU Qcow Disk Image"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x51, 0x57, 0x20, 0x56, 0x65, 0x72, 0x2E, 0x20 },
                offset = 0,
                extention = "abd, qsd",
                description = "Quicken data file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("R.o.o.t..E.n.t.r.y."),
                offset = 0,
                extention = "msg",
                description = "Outlook/Exchange message subheader (Microsoft Office)"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("RAZATDB1"),
                offset = 0,
                extention = "dat",
                description = "Shareaza (Windows P2P client) thumbnail"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("REGEDIT"),
                offset = 0,
                extention = "reg, sud",
                description = "Windows NT Registry and Registry Undo files"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("REVNUM:,"),
                offset = 0,
                extention = "adf",
                description = "Antenna data file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("RTSS"),
                offset = 0,
                extention = "cap",
                description = "Windows NT Netmon capture file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x52, 0x61, 0x72, 0x21, 0x1A, 0x07, 0x00 },
                offset = 0,
                extention = "rar",
                description = "RAR (v4.x) compressed archive file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x52, 0x61, 0x72, 0x21, 0x1A, 0x07, 0x01, 0x00 },
                offset = 0,
                extention = "rar",
                description = "RAR (v5) compressed archive file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("SCMI"),
                offset = 0,
                extention = "img",
                description = "Img Software Set Bitmap"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("SDPX"),
                offset = 0,
                extention = "dpx",
                description = "Digital Picture Exchange (DPX) image file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("SHOW"),
                offset = 0,
                extention = "shw",
                description = "Harvard Graphics DOS Ver. 2/x Presentation file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("SIETRONICS XRD SCAN"),
                offset = 0,
                extention = "cpi",
                description = "Sietronics CPI XRD document"
            });
            
            SignList.Add(new Sign() {
                signature = new byte[] { 0x53, 0x49, 0x4D, 0x50, 0x4C, 0x45, 0x20, 0x20, 0x3D, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x54 },
                offset = 0,
                extention = "fits",
                description = "Flexible Image Transport System (FITS), Version 3.0 file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x53, 0x49, 0x54, 0x21, 0x00 },
                offset = 0,
                extention = "sit",
                description = "StuffIt compressed archive"
            });
            
            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("SMARTDRW"),
                offset = 0,
                extention = "sdr",
                description = "SmartDraw Drawing file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x53, 0x50, 0x46, 0x49, 0x00 },
                offset = 0,
                extention = "spf",
                description = "StorageCraft ShadownProtect backup file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("SPVB"),
                offset = 0,
                extention = "SPVCHAIN",
                description = "MultiBit Bitcoin blockchain file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x53, 0x51, 0x4C, 0x4F, 0x43, 0x4F, 0x4E, 0x56, 0x48, 0x44, 0x00, 0x00, 0x31, 0x2E, 0x30, 0x00 },
                offset = 0,
                extention = "cnv",
                description = "DB2 conversion file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x53, 0x51, 0x4C, 0x69, 0x74, 0x65, 0x20, 0x66, 0x6F, 0x72, 0x6D, 0x61, 0x74, 0x20, 0x33, 0x00 },
                offset = 0,
                extention = "db",
                description = "SQLite database file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x5A, 0x20, 0x88, 0xF0, 0x27, 0x33, 0xD1 },
                offset = 0,
                extention = null,
                description = "QBASIC SZDD file header variant."
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("StuffIt(c)1997 - "),
                offset = 0,
                extention = "sit",
                description = "StuffIt compressed archive"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("SuperCalc"),
                offset = 0,
                extention = "cal",
                description = "SuperCalc worksheet"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x54, 0x48, 0x50, 0x00 },
                offset = 0,
                extention = "thp",
                description = "Wii/GameCube video file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("UCEX"),
                offset = 0,
                extention = "uce",
                description = "Unicode extensions"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x55, 0x46, 0x41, 0xC6, 0xD2, 0xC1 },
                offset = 0,
                extention = "ufa",
                description = "UFA compressed archive"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x55, 0x46, 0x4F, 0x4F, 0x72, 0x62, 0x69, 0x74 },
                offset = 0,
                extention = "dat",
                description = "UFO Capture v2 map file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("VCPCH0"),
                offset = 0,
                extention = "pch",
                description = "Visual C PreCompiled header file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("WMMP"),
                offset = 0,
                extention = "dat",
                description = "Walkman MP3 container file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("WS2000"),
                offset = 0,
                extention = "ws2",
                description = "WordStar for Windows Ver. 2 document"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("WinZip"),
                offset = 29152,
                extention = "zip",
                description = "WinZip compressed archive"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("WordPro"),
                offset = 0,
                extention = "lwp",
                description = "Lotus WordPro document"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x58, 0x43, 0x50, 0x00 },
                offset = 0,
                extention = "cap",
                description = "Cinco NetXRay, Network General Sniffer, and Network Associates Sniffer capture file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x58, 0x50, 0x43, 0x4F, 0x4D, 0x0A, 0x54, 0x79, 0x70, 0x65, 0x4C, 0x69, 0x62 },
                offset = 0,
                extention = "xpt",
                description = "XPCOM type libraries for the XPIDL compiler"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("XPDS"),
                offset = 0,
                extention = "dpx",
                description = "Digital Picture Exchange (DPX) image file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x5A, 0x4F, 0x4F, 0x20 },
                offset = 0,
                extention = "zoo",
                description = "ZOO compressed archive"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("ZWF"),
                offset = 0,
                extention = "swf",
                description = "Macromedia Shockwave Flash player file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x5B, 0x47, 0x65, 0x6E, 0x65, 0x72, 0x61, 0x6C, 0x5D, 0x0D, 0x0A, 0x44, 0x69, 0x73, 0x70, 0x6C, 0x61, 0x79, 0x20, 0x4E, 0x61, 0x6D, 0x65, 0x3D, 0x3C, 0x44, 0x69, 0x73, 0x70, 0x6C, 0x61, 0x79, 0x4E, 0x61, 0x6D, 0x65 },
                offset = 0,
                extention = "ecf",
                description = "Microsoft Exchange 2007 extended configuration file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("[MSVC"),
                offset = 0,
                extention = "vcw",
                description = "Microsoft Visual C++ Workbench Information File"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x5B, 0x57, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x73, 0x20, 0x4C, 0x61, 0x74, 0x69, 0x6E, 0x20 },
                offset = 0,
                extention = "cpx",
                description = "Microsoft Code Page Translation file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x5D, 0xFC, 0xC8, 0x00 },
                offset = 0,
                extention = "hus",
                description = "Husqvarna Designer I Embroidery Machine file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x5F, 0x27, 0xA8, 0x89 },
                offset = 0,
                extention = "jar",
                description = "Jar archive"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x63, 0x75, 0x73, 0x68, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00 },
                offset = 0,
                extention = "csh",
                description = "Photoshop Custom Shape"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x64, 0x00, 0x00, 0x00 },
                offset = 0,
                extention = "P10",
                description = "Intel PROset/Wireless Profile"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x64, 0x65, 0x78, 0x0A },
                offset = 0,
                extention = "dex",
                description = "Dalvik executable file (Android)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x64, 0x6E, 0x73, 0x2E },
                offset = 0,
                extention = "au",
                description = "Audacity audio file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("dswfile"),
                offset = 0,
                extention = "dsw",
                description = "Microsoft Visual Studio workspace file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("encrcdsa"),
                offset = 0,
                extention = "dmg",
                description = "Macintosh encrypted Disk image (v2)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x66, 0x49, 0x00, 0x00 },
                offset = 0,
                extention = "shd",
                description = "Windows NT printer spool file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x66, 0x4C, 0x61, 0x43, 0x00, 0x00, 0x00, 0x22 },
                offset = 0,
                extention = "flac",
                description = "Free Lossless Audio Codec file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("ftyp3gp"),
                offset = 4,
                extention = "3gg, 3gp, 3g2",
                description = "3rd Generation Partnership Project 3GPP multimedia files"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("ftypM4A"),
                offset = 4,
                extention = "M4A",
                description = "Apple Lossless Audio Codec file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("ftypM4V"),
                offset = 4,
                extention = "flv, mp4",
                description = "ISO Media, MPEG v4 system, or iTunes AVC-LC file."
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("ftypMSNV"),
                offset = 4,
                extention = "mp4",
                description = "MPEG-4 video file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("ftypisom"),
                offset = 4,
                extention = "mp4",
                description = "ISO Base Media file (MPEG-4) v1"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("ftypmp42"),
                offset = 4,
                extention = "m4v",
                description = "MPEG-4 video|QuickTime file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("ftypqt"),
                offset = 4,
                extention = "mov",
                description = "QuickTime movie file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x67, 0x49, 0x00, 0x00 },
                offset = 0,
                extention = "shd",
                description = "Windows 2000/XP printer spool file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("gimp xcf"),
                offset = 0,
                extention = "xcf",
                description = "GNU Image Manipulation Program (GIMP) eXperimental Computing Facility (XCF) image file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x68, 0x49, 0x00, 0x00 },
                offset = 0,
                extention = "shd",
                description = "Windows Server 2003 printer spool file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x6C, 0x33, 0x33, 0x6C },
                offset = 0,
                extention = "dbb",
                description = "Skype user data file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("moov"),
                offset = 4,
                extention = "mov",
                description = "QuickTime movie file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("mdat"),
                offset = 4,
                extention = "mov",
                description = "QuickTime movie file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("wide"),
                offset = 4,
                extention = "mov",
                description = "QuickTime movie file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("pnot"),
                offset = 4,
                extention = "mov",
                description = "QuickTime movie file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("msFilterList"),
                offset = 0,
                extention = "tpl",
                description = "	Internet Explorer v11 Tracking Protection List file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("multiBit.info"),
                offset = 0,
                extention = "info",
                description = "MultiBit Bitcoin wallet information file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("opdata01"),
                offset = 0,
                extention = null,
                description = "1Password 4 Cloud Keychain encrypted data"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x74, 0x72, 0x75, 0x65, 0x00 },
                offset = 0,
                extention = "ttf",
                description = "TrueType font file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("ustar"),
                offset = 257,
                extention = "tar",
                description = "Tape Archive file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x76, 0x2F, 0x31, 0x01 },
                offset = 0,
                extention = "exr",
                description = "OpenEXR bitmap image format"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x76, 0x32, 0x30, 0x30, 0x33, 0x2E, 0x31, 0x30, 0x0D, 0x0A, 0x30, 0x0D, 0x0A },
                offset = 0,
                extention = "flt",
                description = "	Qimage filter"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x78, 0x01, 0x73, 0x0D, 0x62, 0x62, 0x60 },
                offset = 0,
                extention = "dmg",
                description = "	Mac OS X Disk Copy Disk Image file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("xar!"),
                offset = 0,
                extention = "xar",
                description = "eXtensible ARchive file"
            });

            SignList.Add(new Sign() {
                signature = Encoding.UTF8.GetBytes("zbex"),
                offset = 0,
                extention = "info",
                description = "	ZoomBrowser Image Index file (ZbThumbnal.info)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x7C, 0x4B, 0xC3, 0x74, 0xE1, 0xC8, 0x53, 0xA4, 0x79, 0xB9, 0x01, 0x1D, 0xFC, 0x4F, 0xDD, 0x13 },
                offset = 0,
                extention = "csd",
                description = "Huskygram, Poem, or Singer embroidery design file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x7E, 0x42, 0x4B, 0x00 },
                offset = 0,
                extention = "psp",
                description = "Corel Paint Shop Pro image file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x7E, 0x45, 0x53, 0x44, 0x77, 0xF6, 0x85, 0x3E, 0xBF, 0x6A, 0xD2, 0x11, 0x45, 0x61, 0x73, 0x79, 0x20, 0x53, 0x74, 0x72, 0x65, 0x65, 0x74, 0x20, 0x44, 0x72, 0x61, 0x77 },
                offset = 0,
                extention = "esd",
                description = "Easy Street Draw diagram file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x7F, 0x45, 0x4C, 0x46 },
                offset = 0,
                extention = null,
                description = "Executable and Linking Format executable file (Linux/Unix)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x80, 0x2A, 0x5F, 0xD7 },
                offset = 0,
                extention = "cin",
                description = "Kodak Cineon image file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x81, 0x32, 0x84, 0xC1, 0x85, 0x05, 0xD0, 0x11, 0xB2, 0x90, 0x00, 0xAA, 0x00, 0x3C, 0xF6, 0x76 },
                offset = 0,
                extention = "wab",
                description = "Outlook Express address book (Win95)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x81, 0xCD, 0xAB },
                offset = 0,
                extention = "wpf",
                description = "WordPerfect text file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A },
                offset = 0,
                extention = "png",
                description = "Portable Network Graphics file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x8A, 0x01, 0x09, 0x00, 0x00, 0x00, 0xE1, 0x08, 0x00, 0x00, 0x99, 0x19 },
                offset = 0,
                extention = "aw",
                description = "MS Answer Wizard file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x91, 0x33, 0x48, 0x46 },
                offset = 0,
                extention = "hap",
                description = "Hamarsoft HAP 3.x compressed archive"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x95, 0x00 },
                offset = 0,
                extention = "skr",
                description = "PGP secret keyring file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x95, 0x01 },
                offset = 0,
                extention = "skr",
                description = "PGP secret keyring file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x97, 0x4A, 0x42, 0x32, 0x0D, 0x0A, 0x1A, 0x0A },
                offset = 0,
                extention = "jb2",
                description = "JBOG2 image file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x99, 0x01 },
                offset = 0,
                extention = "pkr",
                description = "PGP public keyring file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0x9C, 0xCB, 0xCB, 0x8D, 0x13, 0x75, 0xD2, 0x11, 0x91, 0x58, 0x00, 0xC0, 0x4F, 0x79, 0x56, 0xA4 },
                offset = 0,
                extention = "wab",
                description = "Outlook address file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { },
                offset = 512,
                extention = "ppt",
                description = "PowerPoint presentation subheader (Microsoft Office)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xA1, 0xB2, 0xC3, 0xD4 },
                offset = 0,
                extention = null,
                description = "tcpdump (libpcap) capture file (Linux/Unix)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xA1, 0xB2, 0xCD, 0x34 },
                offset = 0,
                extention = null,
                description = "Extended tcpdump (libpcap) capture file (Linux/Unix)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xB0, 0x4D, 0x46, 0x43 },
                offset = 0,
                extention = "pwl",
                description = "Windows 95 password file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xB1, 0x68, 0xDE, 0x3A },
                offset = 0,
                extention = "dcx",
                description = "Graphics Multipage PCX bitmap file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xB4, 0x6E, 0x68, 0x44 },
                offset = 0,
                extention = "tib",
                description = "Acronis True Image file (early versions)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xB5, 0xA2, 0xB0, 0xB3, 0xB3, 0xB0, 0xA5, 0xB5 },
                offset = 0,
                extention = "cal",
                description = "Windows calendar file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xBE, 0x00, 0x00, 0x00, 0xAB, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 },
                offset = 0,
                extention = "wri",
                description = "Microsoft Write file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xCA, 0xFE, 0xBA, 0xBE },
                offset = 0,
                extention = "class",
                description = "Java bytecode file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xCD, 0x20, 0xAA, 0xAA, 0x02, 0x00, 0x00, 0x00 },
                offset = 0,
                extention = null,
                description = "Norton Anti-Virus quarantined virus file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xCE, 0x24, 0xB9, 0xA2, 0x20, 0x00, 0x00, 0x00 },
                offset = 0,
                extention = "tib",
                description = "Acronis True Image file (current versions)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xCE, 0xCE, 0xCE, 0xCE },
                offset = 0,
                extention = "lceks",
                description = "Java Cryptography Extension keystore file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xCF, 11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1, 0x00 },
                offset = 0,
                extention = "doc",
                description = "Perfect Office document"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xCF, 0xAD, 0x12, 0xFE },
                offset = 0,
                extention = "dbx",
                description = "Outlook Express e-mail folder"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xD2, 0x0A, 0x00, 0x00 },
                offset = 0,
                extention = "ftr",
                description = "GN Nettest WinPharoah filter file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xD7, 0xCD, 0xC6, 0x9A },
                offset = 0,
                extention = "wmf",
                description = "Windows graphics metafile"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xDB, 0xA5, 0x2D, 0x00 },
                offset = 0,
                extention = "doc",
                description = "Word 2.0 file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xE3, 0x10, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00 },
                offset = 0,
                extention = "info",
                description = "Amiga Icon file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xE3, 0x82, 0x85, 0x96 },
                offset = 0,
                extention = "pwl",
                description = "Windows 98 password file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xE4, 0x52, 0x5C, 0x7B, 0x8C, 0xD8, 0xA7, 0x4D, 0xAE, 0xB1, 0x53, 0x78, 0xD0, 0x29, 0x96, 0xD3 },
                offset = 0,
                extention = "one",
                description = "Microsoft OneNote note"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xEB, 0x3C, 0x90, 0x2A },
                offset = 0,
                extention = "img",
                description = "GEM Raster file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xED, 0xAB, 0xEE, 0xDB },
                offset = 0,
                extention = "rpm",
                description = "RedHat Package Manager file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xF9, 0xBE, 0xB4, 0xD9 },
                offset = 0,
                extention = "dat",
                description = "Bitcoin-Qt blockchain block file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xFD, 0x37, 0x7A, 0x58, 0x5A, 0x00 },
                offset = 0,
                extention = "xz",
                description = "XZ archive file"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xFE, 0xED, 0xFA, 0xCE },
                offset = 0,
                extention = null,
                description = "Apple OS X ABI Mach-O binary file (32-bit)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xFE, 0xED, 0xFA, 0xCF },
                offset = 0,
                extention = null,
                description = "Apple OS X ABI Mach-O binary file (64-bit)"
            });

            SignList.Add(new Sign() {
                signature = new byte[] { 0xFE, 0xED, 0xFE, 0xED },
                offset = 0,
                extention = "jks",
                description = "JavaKeyStore file"
            });
        }

        SignList.Sort((Sign a, Sign b) => {
            //TODO: sort
            return 0;
        });
    }

}
