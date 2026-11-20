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
type VectorAnimationUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : VectorAnimationUtil
    static member instance with get() : VectorAnimationUtil = (VectorAnimationUtil.jclinit(); VectorAnimationUtil.jcell_instance) and set (jvalue: VectorAnimationUtil) = (VectorAnimationUtil.jclinit(); VectorAnimationUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not VectorAnimationUtil.jclinitDone then
            VectorAnimationUtil.jclinitDone <- true
            VectorAnimationUtil.jclinitBody()
    static member private jclinitBody() : unit =
        VectorAnimationUtil.jcell_instance <- (new VectorAnimationUtil())
        ()
    
    static member getInstance() : VectorAnimationUtil =
        VectorAnimationUtil.instance
    
    new () =
        {  }
    
    abstract toAnimationArrayFromListOfPointListWithPointsPerFrame : vector: BasicArrayList * pointsPerFrame: int -> int[][][]
    default this.toAnimationArrayFromListOfPointListWithPointsPerFrame(vector: BasicArrayList, pointsPerFrame: int) : int[][][] =
        let mutable size : int = vector.size()
        let mutable points : int[][][] = (JR.newArray3<int>(size, pointsPerFrame, 2))
        let mutable nextBasicArrayList : BasicArrayList = null
        let mutable framePoints : int[][] = null
        let mutable index : int = 0
        while index < size do
            nextBasicArrayList <- (box (vector.objectArray.[index]) :?> BasicArrayList)
            framePoints <- this.toFrameArrayFromPointBasicArrayList(nextBasicArrayList)
            let mutable pointIndex : int = 0
            while pointIndex < framePoints.Length do
                points.[index].[pointIndex].[0] <- framePoints.[pointIndex].[0]
                points.[index].[pointIndex].[1] <- framePoints.[pointIndex].[1]
                pointIndex <- pointIndex + 1
            index <- index + 1
        points
    
    abstract toAnimationArrayFromListOfPointList : vector: BasicArrayList -> int[][][]
    default this.toAnimationArrayFromListOfPointList(vector: BasicArrayList) : int[][][] =
        let mutable size : int = vector.size()
        let mutable points : int[][][] = (JR.newArray3<int>(size, 0, 0))
        let mutable nextBasicArrayList : BasicArrayList = null
        let mutable framePoints : int[][] = null
        let mutable index : int = 0
        while index < size do
            nextBasicArrayList <- (box (vector.objectArray.[index]) :?> BasicArrayList)
            framePoints <- this.toFrameArrayFromPointBasicArrayList(nextBasicArrayList)
            points.[index] <- (JR.newArray2<int>(framePoints.Length, 2))
            let mutable pointIndex : int = 0
            while pointIndex < framePoints.Length do
                points.[index].[pointIndex].[0] <- framePoints.[pointIndex].[0]
                points.[index].[pointIndex].[1] <- framePoints.[pointIndex].[1]
                pointIndex <- pointIndex + 1
            index <- index + 1
        points
    
    abstract toFrameArrayFromPointBasicArrayList : list_: BasicArrayList -> int[][]
    default this.toFrameArrayFromPointBasicArrayList(list_: BasicArrayList) : int[][] =
        let mutable points : int[][] = (JR.newArray2<int>(list_.size(), 2))
        let mutable size : int = list_.size()
        let mutable index : int = 0
        while index < size do
            let mutable nextPoint : GPoint = (box (list_.objectArray.[index]) :?> GPoint)
            points.[index].[0] <- nextPoint.getX()
            points.[index].[1] <- nextPoint.getY()
            index <- index + 1
        points


