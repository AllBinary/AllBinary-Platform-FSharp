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
type VectorRotationGenerator =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable vectorAnimationUtil : VectorAnimationUtil
    [<DefaultValue(false)>] val mutable angleFactory : AngleFactory
    [<DefaultValue(false)>] static val mutable private jcell_instance : VectorRotationGenerator
    static member instance with get() : VectorRotationGenerator = (VectorRotationGenerator.jclinit(); VectorRotationGenerator.jcell_instance) and set (jvalue: VectorRotationGenerator) = (VectorRotationGenerator.jclinit(); VectorRotationGenerator.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not VectorRotationGenerator.jclinitDone then
            VectorRotationGenerator.jclinitDone <- true
            VectorRotationGenerator.jclinitBody()
    static member private jclinitBody() : unit =
        VectorRotationGenerator.jcell_instance <- (new VectorRotationGenerator())
        ()
    member this.jfields_VectorRotationGenerator() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.vectorAnimationUtil <- VectorAnimationUtil.getInstance()
        this.angleFactory <- AngleFactory.getInstance()
        ()
    
    static member getInstance_jstatic() : VectorRotationGenerator =
        VectorRotationGenerator.instance
    
    new () as this =
        {  }
        then
            this.jfields_VectorRotationGenerator()
    
    abstract getInstance : vectorRotationInfo: VectorInfo -> int[][][]
    default this.getInstance(vectorRotationInfo: VectorInfo) : int[][][] =
        this.getInstanceFrames(vectorRotationInfo.getWidth(), vectorRotationInfo.getHeight(), vectorRotationInfo.getPoints(), vectorRotationInfo.getTotalFrames())
    
    abstract getInstanceFrames : width: int * height: int * points: int[][] * frames: int -> int[][][]
    default this.getInstanceFrames(width: int, height: int, points: int[][], frames: int) : int[][][] =
        let mutable jflow = 0
        let mutable jret : int[][][] = Unchecked.defaultof<int[][][]>
        try
            let mutable totalAngle : int16 = this.angleFactory.TOTAL_ANGLE
            let mutable angleIncrement : int = int (int (totalAngle)) / frames
            let mutable pointsBasicArrayList : BasicArrayList = (new BasicArrayListS((int (int (totalAngle)) / angleIncrement)))
            let mutable pointBasicArrayList : BasicArrayList = (new BasicArrayListS(points.Length))
            let mutable pointFactory : PointFactory = PointFactory.getInstance()
            let mutable size : int = points.Length
            let mutable index : int = 0
            while index < size do
                ignore (pointBasicArrayList.add(pointFactory.createXY(points.[index].[0], points.[index].[1])))
                index <- index + 1
            let mutable index : int = 0
            while index < int (int (totalAngle)) do
                ignore (pointsBasicArrayList.add(this.getListAtAngle(width, height, pointBasicArrayList, this.angleFactory.getAt(index))))
                index <- index + angleIncrement
            let mutable newPoints : int[][][] = this.vectorAnimationUtil.toAnimationArrayFromListOfPointListWithPointsPerFrame(pointsBasicArrayList, pointBasicArrayList.size())
            jret <- newPoints
            jflow <- 1
        with jex ->
            match JR.throwable(jex) with
            | :? JException as e ->
                let mutable commonStrings : CommonStrings = CommonStrings.getInstance()
                this.logUtil.put(commonStrings.EXCEPTION, this, commonStrings.GET_INSTANCE, e)
                jret <- NullUtil.getInstance().NULL_INT_ARRAY_ARRAY_ARRAY
                jflow <- 1
            | _ -> reraise ()
        jret
    
    abstract getListAtAngle : width: int * height: int * pointBasicArrayList: BasicArrayList * angle: Angle -> BasicArrayList
    default this.getListAtAngle(width: int, height: int, pointBasicArrayList: BasicArrayList, angle: Angle) : BasicArrayList =
        let mutable graphicsPipe : BasicGraphicsPipeline = (new BasicGraphicsPipeline(pointBasicArrayList))
        graphicsPipe.createMatrix()
        graphicsPipe.translate(-((width >>> 1)), -((height >>> 1)))
        graphicsPipe.rotateToAngle(angle)
        graphicsPipe.translate((width >>> 1), (height >>> 1))
        graphicsPipe.getMatrix()


