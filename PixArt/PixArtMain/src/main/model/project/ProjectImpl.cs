﻿
using PixArtMain.main.model.historyframe;
using PixArtMain.main.model.matrix;

namespace PixArtMain.main.model.project;

public class ProjectImpl : IProject
{
    private String ProjectName { get; }
    private String Path { get; }
    private String FileType { get; }
    private List<IMatrix> _frames = new List<IMatrix>();
    private List<IHistoryFrame> _historyFrames = new List<IHistoryFrame>();


    public void AddNewFrame()
    {
        this._frames.Add(new MatrixImpl(16, 16));
    }

    public void AddNewHistoryFrame(int index)
    {
        this._historyFrames.Add(new HistoryFrameImpl());
    }
}