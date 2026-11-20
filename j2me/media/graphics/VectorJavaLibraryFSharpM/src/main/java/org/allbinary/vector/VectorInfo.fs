namespace rec AllBinary

// Generated Code Do Not Modify
(*
 *
 * AllBinary Open License Version 1
 * Copyright (c) 2011 AllBinary
 * 
 * By agreeing to this license you and any business entity you represent are
 * legally bound to the AllBinary Open License Version 1 legal agreement.
 * 
 * You may obtain the AllBinary Open License Version 1 legal agreement from
 * AllBinary or the root directory of AllBinary's AllBinary Platform repository.
 * 
 * Created By: Travis Berthelot
 *  
 *)

[<AllowNullLiteral>]
type VectorInfo =
    [<DefaultValue(false)>] val mutable width : int
    [<DefaultValue(false)>] val mutable height : int
    [<DefaultValue(false)>] val mutable points : int[][]
    [<DefaultValue(false)>] val mutable totalFrames : int
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not VectorInfo.jclinitDone then
            VectorInfo.jclinitDone <- true
            VectorInfo.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (width: int, height: int, points: int[][], totalFrames: int) as this =
        {  }
        then
            this.jctor1(width, height, points, totalFrames)
    member this.jctor1(width: int, height: int, points: int[][], totalFrames: int) : unit =
        this.width <- width
        this.height <- height
        this.points <- points
        this.totalFrames <- totalFrames
        ()
    
    abstract getWidth : unit -> int
    default this.getWidth() : int =
        this.width
    
    member this.setWidth(width: int) : unit =
        this.width <- width
    
    abstract getHeight : unit -> int
    default this.getHeight() : int =
        this.height
    
    member this.setHeight(height: int) : unit =
        this.height <- height
    
    abstract getPoints : unit -> int[][]
    default this.getPoints() : int[][] =
        this.points
    
    member this.setPoints(points: int[][]) : unit =
        this.points <- points
    
    abstract getTotalFrames : unit -> int
    default this.getTotalFrames() : int =
        this.totalFrames
    
    member this.setTotalFrames(totalFrames: int) : unit =
        this.totalFrames <- totalFrames


