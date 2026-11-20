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
type PointsUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : PointsUtil
    static member instance with get() : PointsUtil = (PointsUtil.jclinit(); PointsUtil.jcell_instance) and set (jvalue: PointsUtil) = (PointsUtil.jclinit(); PointsUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PointsUtil.jclinitDone then
            PointsUtil.jclinitDone <- true
            PointsUtil.jclinitBody()
    static member private jclinitBody() : unit =
        PointsUtil.jcell_instance <- (new PointsUtil())
        ()
    new () =
        {  }
    
    static member getInstance() : PointsUtil =
        PointsUtil.instance
    
    abstract adjustXY : points: int[][][] * x: int * y: int -> int[][][]
    default this.adjustXY(points: int[][][], x: int, y: int) : int[][][] =
        let mutable size : int = points.Length
        let mutable newPoints : int[][][] = (JR.newArray3<int>(size, 0, 0))
        let mutable index : int = 0
        while index < size do
            let mutable size2 : int = points.[index].Length
            newPoints.[index] <- (JR.newArray2<int>(size2, 2))
            let mutable index2 : int = 0
            while index2 < size2 do
                if points.[index].[index2].[0] <> 1000 then
                    newPoints.[index].[index2].[0] <- points.[index].[index2].[0] + x
                    newPoints.[index].[index2].[1] <- points.[index].[index2].[1] + y
                else
                    newPoints.[index].[index2].[0] <- 1000
                    newPoints.[index].[index2].[1] <- 1000
                index2 <- index2 + 1
            index <- index + 1
        newPoints
    
    abstract adjust : points: int[][] * both: int -> int[][]
    default this.adjust(points: int[][], both: int) : int[][] =
        this.adjust(points, both, both)
    
    abstract adjust : points: int[][] * x: int * y: int -> int[][]
    default this.adjust(points: int[][], x: int, y: int) : int[][] =
        let mutable newPoints : int[][] = (JR.newArray2<int>(points.Length, 2))
        let mutable index2 : int = 0
        while index2 < points.Length do
            if points.[index2].[0] <> 1000 then
                newPoints.[index2].[0] <- points.[index2].[0] + x
                newPoints.[index2].[1] <- points.[index2].[1] + y
            else
                newPoints.[index2].[0] <- 1000
                newPoints.[index2].[1] <- 1000
            index2 <- index2 + 1
        newPoints


