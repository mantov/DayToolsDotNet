using DayToolsDotNet;
using Microsoft.VisualStudio.Text;
using System;
using Community.VisualStudio.Toolkit;
using EnvDTE;
using Microsoft.VisualStudio.Shell;

namespace DayToolsDotNet.Commands
{
    //[Command(PackageIds.)]
    //internal sealed class IpsumLoremCommand : BaseCommand<IpsumLoremCommand>
    //{
    //    protected override async Task ExecuteAsync(OleMenuCmdEventArgs e)
    //    {
    //        await Package.JoinableTaskFactory.SwitchToMainThreadAsync();
    //        DocumentView docView = await VS.Documents.GetActiveDocumentViewAsync();
    //        if (docView?.TextView == null) return;
    //        SnapshotPoint position = docView.TextView.Caret.Position.BufferPosition;
    //        var textoIpsum = new NLipsum.Core.LipsumGenerator().GenerateLipsum(1000);
    //        docView.TextBuffer?.Insert(position, textoIpsum);
    //    }
    //}
}