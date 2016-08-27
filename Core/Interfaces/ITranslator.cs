using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ITranslator
    {
        bool IsAvailable { get; }

        Translation GetTranslate(TextToTranslate textToTranslate);

        Task<Translation> GetTranslateAsync(TextToTranslate textToTranslate);

        Task<Translation> GetTranslateAsync(TextToTranslate textToTranslate, CancellationToken token);
    }
}
