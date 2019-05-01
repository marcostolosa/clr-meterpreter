﻿using Met.Core;
using System;
using System.Collections.Generic;

namespace TestConsole.net35
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<byte[]>
            {
                new byte[]
                {
                    0x27, 0x60, 0x4e, 0x1e, 0x27, 0x60, 0x4e, 0x1e, 0x27, 0x60, 0x4e, 0x1e, 0x27, 0x60, 0x4e, 0x1e,
                    0x27, 0x60, 0x4e, 0x1e, 0x27, 0x60, 0x4e, 0x1e, 0x27, 0x60, 0x4c, 0x3d, 0x27, 0x60, 0x4e, 0x1e,
                    0x27, 0x60, 0x4e, 0x38, 0x27, 0x61, 0x4e, 0x1f, 0x44, 0x0f, 0x3c, 0x7b, 0x78, 0x0e, 0x2b, 0x79,
                    0x48, 0x14, 0x27, 0x7f, 0x53, 0x05, 0x11, 0x6a, 0x4b, 0x16, 0x11, 0x7b, 0x49, 0x03, 0x3c, 0x67,
                    0x57, 0x14, 0x27, 0x71, 0x49, 0x60, 0x4e, 0x1e, 0x27, 0x49, 0x4e, 0x1f, 0x27, 0x62, 0x7a, 0x2d,
                    0x17, 0x55, 0x76, 0x2a, 0x11, 0x59, 0x79, 0x2f, 0x10, 0x51, 0x79, 0x2a, 0x14, 0x59, 0x76, 0x2b,
                    0x13, 0x55, 0x7b, 0x26, 0x12, 0x57, 0x7e, 0x2c, 0x1f, 0x59, 0x78, 0x27, 0x17, 0x57, 0x4e, 0x1e,
                    0x27, 0x61, 0x82, 0x1e, 0x26, 0x62, 0x68, 0x33, 0x0a, 0x4d, 0x63, 0x33, 0x65, 0x25, 0x09, 0x57,
                    0x69, 0x40, 0x1e, 0x4b, 0x65, 0x2c, 0x07, 0x5d, 0x07, 0x2b, 0x0b, 0x47, 0x0a, 0x4d, 0x63, 0x33,
                    0x0a, 0x6a, 0x03, 0x57, 0x6e, 0x22, 0x07, 0x74, 0x66, 0x2e, 0x0c, 0x79, 0x4c, 0x11, 0x26, 0x75,
                    0x4e, 0x27, 0x77, 0x69, 0x17, 0x22, 0x0f, 0x4f, 0x62, 0x26, 0x0f, 0x5f, 0x68, 0x23, 0x0f, 0x4f,
                    0x1f, 0x21, 0x03, 0x57, 0x6e, 0x22, 0x0d, 0x79, 0x6c, 0x23, 0x0f, 0x4f, 0x62, 0x21, 0x37, 0x56,
                    0x08, 0x29, 0x3d, 0x79, 0x10, 0x19, 0x27, 0x69, 0x6a, 0x38, 0x2b, 0x44, 0x61, 0x18, 0x0d, 0x77,
                    0x6c, 0x0a, 0x44, 0x64, 0x54, 0x52, 0x34, 0x2c, 0x48, 0x28, 0x3a, 0x4d, 0x4c, 0x38, 0x1e, 0x50,
                    0x56, 0x19, 0x77, 0x31, 0x49, 0x24, 0x17, 0x4e, 0x76, 0x0c, 0x0b, 0x67, 0x13, 0x04, 0x1e, 0x2c,
                    0x43, 0x2c, 0x38, 0x46, 0x63, 0x4b, 0x05, 0x5c, 0x08, 0x0f, 0x39, 0x27, 0x62, 0x19, 0x1f, 0x73,
                    0x65, 0x11, 0x16, 0x5c, 0x4f, 0x2c, 0x7b, 0x51, 0x16, 0x38, 0x76, 0x5f, 0x08, 0x29, 0x29, 0x6a,
                    0x40, 0x04, 0x18, 0x14, 0x43, 0x23, 0x7e, 0x4f, 0x10, 0x33, 0x3f, 0x53, 0x6b, 0x52, 0x08, 0x49,
                    0x40, 0x39, 0x3c, 0x78, 0x57, 0x06, 0x37, 0x7d, 0x66, 0x05, 0x0c, 0x5a, 0x4c, 0x2c, 0x27, 0x49,
                    0x73, 0x25, 0x26, 0x53, 0x53, 0x2c, 0x36, 0x2f, 0x74, 0x17, 0x36, 0x2d, 0x52, 0x57, 0x7c, 0x4b,
                    0x45, 0x23, 0x65, 0x76, 0x40, 0x19, 0x2c, 0x4d, 0x7f, 0x12, 0x77, 0x7d, 0x4c, 0x0e, 0x14, 0x31,
                    0x65, 0x2d, 0x3d, 0x76, 0x2d, 0x07, 0x17, 0x54, 0x66, 0x51, 0x7c, 0x2c, 0x44, 0x51, 0x39, 0x78,
                    0x7e, 0x29, 0x7d, 0x59, 0x6d, 0x0c, 0x3b, 0x51, 0x51, 0x24, 0x1e, 0x47, 0x62, 0x11, 0x1d, 0x50,
                    0x73, 0x51, 0x2b, 0x44, 0x6f, 0x57, 0x0a, 0x4f, 0x49, 0x0b, 0x19, 0x4c, 0x41, 0x58, 0x14, 0x51,
                    0x41, 0x24, 0x04, 0x4c, 0x1e, 0x1a, 0x23, 0x53, 0x46, 0x59, 0x1e, 0x6e, 0x62, 0x0a, 0x3e, 0x54,
                    0x45, 0x56, 0x22, 0x31, 0x72, 0x6a, 0x25, 0x51, 0x62, 0x13, 0x0c, 0x2d, 0x1e, 0x21, 0x3b, 0x66,
                    0x6f, 0x23, 0x27, 0x51, 0x65, 0x4b, 0x7b, 0x52, 0x13, 0x11, 0x7b, 0x53, 0x68, 0x07, 0x76, 0x59,
                    0x7e, 0x11, 0x0d, 0x6b, 0x57, 0x35, 0x0b, 0x2a, 0x54, 0x2d, 0x05, 0x28, 0x4b, 0x54, 0x28, 0x68,
                    0x44, 0x34, 0x77, 0x5f, 0x11, 0x57, 0x7c, 0x4b, 0x5e, 0x3a, 0x05, 0x76, 0x5e, 0x16, 0x0a, 0x49,
                    0x60, 0x1a, 0x25, 0x50, 0x53, 0x22, 0x44, 0x48, 0x76, 0x26, 0x21, 0x6a, 0x72, 0x04, 0x1f, 0x74,
                    0x6d, 0x0f, 0x3b, 0x49, 0x4f, 0x19, 0x0d, 0x69, 0x48, 0x33, 0x0c, 0x79, 0x65, 0x28, 0x2c, 0x52,
                    0x43, 0x50, 0x21, 0x72, 0x6e, 0x36, 0x02, 0x73, 0x66, 0x11, 0x01, 0x79, 0x6d, 0x57, 0x3d, 0x2d,
                    0x7e, 0x16, 0x01, 0x2c, 0x70, 0x50, 0x20, 0x7d, 0x56, 0x04, 0x25, 0x48, 0x15, 0x2a, 0x21, 0x48,
                    0x76, 0x2b, 0x78, 0x73, 0x7e, 0x25, 0x61, 0x14, 0x7d, 0x31, 0x07, 0x5a, 0x66, 0x31, 0x0f, 0x5c,
                    0x2d, 0x4d, 0x63, 0x33, 0x0a, 0x4d, 0x0b, 0x50, 0x63, 0x40, 0x1e, 0x4b, 0x65, 0x2c, 0x07, 0x5d,
                    0x07, 0x2b, 0x0b, 0x47, 0x0a, 0x4d, 0x63, 0x33, 0x0a, 0x6a, 0x4e
                },
                new byte[]
                {
                    0x7c, 0x35, 0x69, 0x8b, 0x42, 0xe7, 0xb9, 0x48, 0x65, 0x13, 0x23, 0x7c, 0xf4, 0x6d, 0x87, 0x5f,
                    0xfe, 0x87, 0xdc, 0xbf, 0x7c, 0x35, 0x69, 0x8b, 0x7c, 0x35, 0x69, 0xc2, 0x7c, 0x35, 0x69, 0x8b,
                    0x7c, 0x35, 0x69, 0x93, 0x7c, 0x34, 0x69, 0x8a, 0x1f, 0x5a, 0x1b, 0xee, 0x23, 0x58, 0x08, 0xe8,
                    0x14, 0x5c, 0x07, 0xee, 0x23, 0x5c, 0x0d, 0x8b, 0x7c, 0x35, 0x69, 0xa2, 0x7c, 0x34, 0x69, 0x89,
                    0x4d, 0x05, 0x5f, 0xbc, 0x4f, 0x02, 0x5a, 0xba, 0x4e, 0x04, 0x50, 0xbb, 0x49, 0x05, 0x58, 0xb9,
                    0x4f, 0x00, 0x51, 0xb8, 0x48, 0x06, 0x5b, 0xb8, 0x4b, 0x03, 0x58, 0xba, 0x4f, 0x02, 0x59, 0xbf,
                    0x7c
                },
                new byte[]
                {
                    0xb7, 0x3a, 0xbf, 0xf0, 0x89, 0xe8, 0x6f, 0x33, 0xae, 0x1c, 0xf5, 0x07, 0x3f, 0x62, 0x51, 0x24,
                    0x35, 0x88, 0x0a, 0xc4, 0xb7, 0x3a, 0xbf, 0xf0, 0xb7, 0x3a, 0xbf, 0xaa, 0xb7, 0x3a, 0xbf, 0xf0,
                    0xb7, 0x3a, 0xbf, 0xd9, 0xb7, 0x3b, 0xbf, 0xf1, 0xc4, 0x4e, 0xdb, 0x91, 0xc7, 0x53, 0xe0, 0x9e,
                    0xd2, 0x4e, 0xe0, 0x93, 0xd8, 0x54, 0xd9, 0x99, 0xd0, 0x65, 0xd8, 0x95, 0xc3, 0x65, 0xd6, 0x9e,
                    0xc3, 0x5f, 0xcd, 0x96, 0xd6, 0x59, 0xda, 0x83, 0xb7, 0x3a, 0xbf, 0xf0, 0x9e, 0x3a, 0xbe, 0xf0,
                    0xb5, 0x09, 0x8e, 0xc2, 0x86, 0x0e, 0x8e, 0xc6, 0x81, 0x0f, 0x8c, 0xc1, 0x85, 0x0a, 0x8a, 0xc8,
                    0x8e, 0x0b, 0x87, 0xc7, 0x84, 0x0f, 0x8b, 0xc2, 0x84, 0x0a, 0x8a, 0xc6, 0x81, 0x0f, 0x8a, 0xc3,
                    0x80, 0x3a
                }
            };

            foreach (var d in data)
            {
                var packet = new Packet(d);
                Console.WriteLine(packet.ToString());
            }
        }
    }
}
