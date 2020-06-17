﻿using System;
namespace Crispy_Waddle_Core
{
    public class AlbumNumberHelper: IAlbumNumberHelper
    {
        public static bool ValidNumber(string albumNumber) {
            try {
                int albumNumberInt = int.Parse(albumNumber);
                return albumNumberInt >= 1 && albumNumberInt <= 100;
            } catch {
                return false;
            }
        }

    }
}
