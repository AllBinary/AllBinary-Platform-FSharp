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
type VectorExplosionGenerator =
    [<DefaultValue(false)>] val mutable RANDOM : VectorExplosionType
    [<DefaultValue(false)>] val mutable ROTATION : VectorExplosionType
    [<DefaultValue(false)>] val mutable vectorAnimationUtil : VectorAnimationUtil
    [<DefaultValue(false)>] val mutable randomRotationFactory : RandomRotationFactory
    [<DefaultValue(false)>] static val mutable private jcell_instance : VectorExplosionGenerator
    static member instance with get() : VectorExplosionGenerator = (VectorExplosionGenerator.jclinit(); VectorExplosionGenerator.jcell_instance) and set (jvalue: VectorExplosionGenerator) = (VectorExplosionGenerator.jclinit(); VectorExplosionGenerator.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not VectorExplosionGenerator.jclinitDone then
            VectorExplosionGenerator.jclinitDone <- true
            VectorExplosionGenerator.jclinitBody()
    static member private jclinitBody() : unit =
        VectorExplosionGenerator.jcell_instance <- (new VectorExplosionGenerator())
        ()
    member this.jfields_VectorExplosionGenerator() : unit =
        this.RANDOM <- (new VectorExplosionType())
        this.ROTATION <- (new VectorExplosionType())
        this.vectorAnimationUtil <- VectorAnimationUtil.getInstance()
        this.randomRotationFactory <- RandomRotationFactory.getInstance()
        ()
    
    static member getInstance_jstatic() : VectorExplosionGenerator =
        VectorExplosionGenerator.instance
    
    new () as this =
        {  }
        then
            this.jfields_VectorExplosionGenerator()
    
    abstract createList : list_: BasicArrayList * howMuch: int * type_: VectorExplosionType -> BasicArrayList
    default this.createList(list_: BasicArrayList, howMuch: int, type_: VectorExplosionType) : BasicArrayList =
        let mutable point : GPoint = null
        let mutable size : int = list_.size()
        let mutable points : int[][] = (JR.newArray2<int>(size, 2))
        let mutable index : int = 0
        while index < size do
            point <- (box (list_.objectArray.[index]) :?> GPoint)
            points.[index].[0] <- point.getX()
            points.[index].[1] <- point.getY()
            index <- index + 1
        this.createListFromPoints(list_, points, howMuch, type_)
    
    abstract getInstance : points: int[][] * howMuch: int * type_: VectorExplosionType -> int[][][]
    default this.getInstance(points: int[][], howMuch: int, type_: VectorExplosionType) : int[][][] =
        let mutable pointsBasicArrayList : BasicArrayList = this.getInstanceStartFrame(points, howMuch, type_, true)
        let mutable tempBasicArrayList : BasicArrayList = (box (pointsBasicArrayList.objectArray.[0]) :?> BasicArrayList)
        let mutable newPoints : int[][][] = this.vectorAnimationUtil.toAnimationArrayFromListOfPointListWithPointsPerFrame(pointsBasicArrayList, tempBasicArrayList.size())
        newPoints
    
    abstract getInstanceStartFrame : points: int[][] * howMuch: int * type_: VectorExplosionType * startFrame: bool -> BasicArrayList
    default this.getInstanceStartFrame(points: int[][], howMuch: int, type_: VectorExplosionType, startFrame: bool) : BasicArrayList =
        let mutable jflow = 0
        let mutable jret : BasicArrayList = Unchecked.defaultof<BasicArrayList>
        try
            let mutable pointsBasicArrayList : BasicArrayList = (new BasicArrayListS(howMuch))
            ignore (pointsBasicArrayList.add(this.createPointsBasicArrayList(points)))
            let mutable frameIndex : int = 0
            let mutable tempBasicArrayList : BasicArrayList = null
            let mutable pointBasicArrayList : BasicArrayList = null
            while frameIndex < howMuch do
                tempBasicArrayList <- (box (pointsBasicArrayList.objectArray.[frameIndex]) :?> BasicArrayList)
                pointBasicArrayList <- this.createListFromPoints(tempBasicArrayList, points, howMuch, type_)
                ignore (pointsBasicArrayList.add(pointBasicArrayList))
                frameIndex <- frameIndex + 1
            if not (startFrame) then
                ignore (pointsBasicArrayList.removeAt(0))
            jret <- pointsBasicArrayList
            jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                raise (e)
            | _ -> reraise ()
        jret
    
    member this.createListFromPoints(tempBasicArrayList: BasicArrayList, points: int[][], howMuch: int, type_: VectorExplosionType) : BasicArrayList =
        let mutable jflow = 0
        let mutable jret : BasicArrayList = Unchecked.defaultof<BasicArrayList>
        let mutable index : int = 0
        let mutable pointBasicArrayList : BasicArrayList = (new BasicArrayListD())
        let mutable sectionBasicArrayList : BasicArrayList = null
        while jflow = 0 && (index < points.Length) do
            sectionBasicArrayList <- (new BasicArrayListD())
            while jflow = 0 && (points.[index].[0] <> 1000) do
                ignore (sectionBasicArrayList.add(tempBasicArrayList.objectArray.[index]))
                index <- index + 1
                if index >= points.Length then
                    jflow <- 100004
                if jflow = 200004 then jflow <- 0
            if jflow = 100004 then jflow <- 0
            if jflow = 0 then
                sectionBasicArrayList <- RandomTranslation.getInstance(sectionBasicArrayList, howMuch)
                if (JR.same(type_, this.ROTATION)) then
                    sectionBasicArrayList <- this.randomRotationFactory.getInstanceList(sectionBasicArrayList, howMuch)
                let mutable size : int = sectionBasicArrayList.size()
                let mutable index2 : int = 0
                while index2 < size do
                    ignore (pointBasicArrayList.add(sectionBasicArrayList.objectArray.[index2]))
                    index2 <- index2 + 1
                if index >= points.Length then
                    jflow <- 100003
                elif points.[index].[0] = 1000 then
                    ignore (pointBasicArrayList.add(tempBasicArrayList.objectArray.[index]))
                    index <- index + 1
            if jflow = 200003 then jflow <- 0
        if jflow = 100003 then jflow <- 0
        if jflow = 0 then
            jret <- pointBasicArrayList
            jflow <- 1
        jret
    
    member this.createPointsBasicArrayList(points: int[][]) : BasicArrayList =
        if points.Length = 0 then
            raise ((new JException("Not Points Provided")))
        let mutable firstPointBasicArrayList : BasicArrayList = (new BasicArrayListS(points.Length))
        let mutable pointFactory : PointFactory = PointFactory.getInstance()
        let mutable index : int = 0
        while index < points.Length do
            ignore (firstPointBasicArrayList.add(pointFactory.createXY(points.[index].[0], points.[index].[1])))
            index <- index + 1
        firstPointBasicArrayList


