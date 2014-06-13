using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Drawing;
namespace BCS {
    public class Data {
        private enum Tags {
            Elevation = 0x02100023,
            ExtElevation = 0x02110023,
            LocalRadii = 0x02000023,
            SagittalRadii = 0x02200023,

            PeripheralDegreesModule = 0x01300023,

            LastName = 0x00110023,
            FirstName = 0x00120023,
            BirthDate = 0x00300010,
            LimbusDecentration = 0x190023,
            Diameter = 0x270023,
            PupilDiameter = 0x440046,
            PupilDecentration = 0x180023,
            IrisDiameter = 0x460046,

            Rings = 0x20023,
            Meridians = 0x30024,

            Keratometry = 0x1100023,
            Flat = 0x800046,
            Steep = 0x740046,
            Power = 0x760046,
            Radius = 0x750046,
            Angle = 0x770046
        }
        public readonly PService.Image Img;
        public float IrisDiameter, PupilDiameter;
        public int Rings, Meridians = 256;
        public PointF LimbusDecentration, PupilDecentration;
        public List<float> Elevation, LocalRadii, SagittalRadii;

        public Sequence Flat, Steep;

        public Data(PService.Image img, Stream bcs) {
            this.Img = img;
            this.Elevation = new List<float>();
            this.LocalRadii = new List<float>();
            this.SagittalRadii = new List<float>();
            using (BinaryReader br = new BinaryReader(bcs)) {
                do {
                    int tag = 0;
                    try { tag = br.ReadInt32(); }
                    catch (EndOfStreamException) { break; }
                    int len = br.ReadInt32();
                    string Name = Enum.GetName(typeof(Tags), tag);
                    switch ((Tags)tag) {
                        case Tags.IrisDiameter:
                            IrisDiameter = br.ReadSingle();
                            break;
                        case Tags.PupilDiameter:
                            PupilDiameter = br.ReadSingle();
                            break;
                        case Tags.PupilDecentration:
                            PupilDecentration = new PointF(br.ReadSingle(), br.ReadSingle());
                            break;
                        case Tags.LimbusDecentration:
                            LimbusDecentration = new PointF(br.ReadSingle(), br.ReadSingle());
                            break;
                        case Tags.Keratometry:
                            ReadSequence(new MemoryStream(br.ReadBytes(len)));
                            break;
                        case Tags.Rings:
                            Rings = br.ReadInt16();
                            break;
                        case Tags.PeripheralDegreesModule:
                            uint item = br.ReadUInt32(); // item
                            int itemlength = br.ReadInt32(); // item length
                            break;
                        case Tags.ExtElevation:
                            using (BinaryReader br1 = new BinaryReader(new MemoryStream(br.ReadBytes(len)))) {
                                do {
                                    try { Elevation.Add(br1.ReadSingle()); }
                                    catch (EndOfStreamException) { break; }
                                } while (true);
                            }
                            break;
                        case Tags.LocalRadii:
                            using (BinaryReader br1 = new BinaryReader(new MemoryStream(br.ReadBytes(len)))) {
                                do {
                                    try { LocalRadii.Add(br1.ReadSingle()); }
                                    catch (EndOfStreamException) { break; }
                                } while (true);
                            }
                            break;
                        case Tags.SagittalRadii:
                            using (BinaryReader br1 = new BinaryReader(new MemoryStream(br.ReadBytes(len)))) {
                                do {
                                    try { SagittalRadii.Add(br1.ReadSingle()); }
                                    catch (EndOfStreamException) { break; }
                                } while (true);
                            }
                            break;
                        default:
                            br.ReadBytes(len);
                            break;
                    }
                } while (true);

            }
        }

        private void ReadSequence(Stream s) {
            using (BinaryReader br = new BinaryReader(s)) {
                do {
                    try {
                        //            Item = 0xe000fffe,
                        uint item = br.ReadUInt32(); // item
                        int itemlength = br.ReadInt32(); // item length
                        ReadItem(new MemoryStream(br.ReadBytes(itemlength)));
                    }
                    catch (EndOfStreamException) { break; }
                } while (true);
            }
        }

        private void ReadItem(Stream s) {
            using (BinaryReader br = new BinaryReader(s)) {
                do {
                    try {
                        int tag = 0;
                        try { tag = br.ReadInt32(); } catch (EndOfStreamException) { break; }
                        int len = br.ReadInt32();
                        switch ((Tags)tag) {
                            case Tags.Flat:
                                if(Flat == null) Flat = new Sequence(new MemoryStream(br.ReadBytes(len)));
                                break;
                            case Tags.Steep:
                                if (Steep == null) Steep = new Sequence(new MemoryStream(br.ReadBytes(len)));
                                break;
                            default:
                                br.ReadBytes(len);
                                break;
                        }
                    }
                    catch (EndOfStreamException) { break; }
                } while (true);
            }
        }

        public class Sequence {
            public float Power, Radius, Diameter;
            public short Angle;
            public Sequence(Stream sq) {
                using (BinaryReader br = new BinaryReader(sq)) {
                    try {
                        do {
                            int tag = 0;
                            try { tag = br.ReadInt32(); }
                            catch (EndOfStreamException) { break; }
                            int len = br.ReadInt32();
                            switch ((Tags)tag) {
                                case Tags.Diameter:
                                    Diameter = br.ReadSingle();
                                    break;
                                case Tags.Power:
                                    Power = br.ReadSingle();
                                    break;
                                case Tags.Radius:
                                    Radius = br.ReadSingle();
                                    break;
                                case Tags.Angle:
                                    Angle = br.ReadInt16();
                                    break;
                                default:
                                    br.ReadBytes(len);
                                    break;
                            }
                        } while (true);

                    }
                    catch (EndOfStreamException) { }
                }

            }
        }

    }
}
