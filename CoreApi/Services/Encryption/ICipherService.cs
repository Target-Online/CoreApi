﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi.Services
{
    public interface ICipherService
    {
        string Encrypt(string input);
        string Decrypt(string cipherText);
    }
}
