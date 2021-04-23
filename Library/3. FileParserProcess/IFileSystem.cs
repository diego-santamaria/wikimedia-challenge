﻿using DS_ProgramingChallengeLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DS_ProgramingChallengeLibrary
{
    public interface IFileSystem
    {
        Task SaveDataAsync(IEnumerable<ContainedDataModel> resultGroupBy, string fileName);
    }
}