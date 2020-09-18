using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceGenerationBAL
{
    public interface IImport
    {
        object P2Import(string FileName);

        object P3Import(string FileName);

        object GLImport(string FileName);
    }
}
