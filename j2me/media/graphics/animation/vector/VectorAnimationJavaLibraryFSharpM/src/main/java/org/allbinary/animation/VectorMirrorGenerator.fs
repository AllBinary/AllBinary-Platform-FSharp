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
type VectorMirrorGenerator =
    [<DefaultValue(false)>] val mutable logUtil : LogUtil
    [<DefaultValue(false)>] val mutable vectorAnimationUtil : VectorAnimationUtil
    [<DefaultValue(false)>] static val mutable private jcell_instance : VectorMirrorGenerator
    static member instance with get() : VectorMirrorGenerator = (VectorMirrorGenerator.jclinit(); VectorMirrorGenerator.jcell_instance) and set (jvalue: VectorMirrorGenerator) = (VectorMirrorGenerator.jclinit(); VectorMirrorGenerator.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not VectorMirrorGenerator.jclinitDone then
            VectorMirrorGenerator.jclinitDone <- true
            VectorMirrorGenerator.jclinitBody()
    static member private jclinitBody() : unit =
        VectorMirrorGenerator.jcell_instance <- (new VectorMirrorGenerator())
        ()
    member this.jfields_VectorMirrorGenerator() : unit =
        this.logUtil <- LogUtil.getInstance()
        this.vectorAnimationUtil <- VectorAnimationUtil.getInstance()
        ()
    
    static member getInstance_jstatic() : VectorMirrorGenerator =
        VectorMirrorGenerator.instance
    
    new () as this =
        {  }
        then
            this.jfields_VectorMirrorGenerator()
    
    abstract getInstance : points: int[][][] * width: int -> int[][][]
    default this.getInstance(points: int[][][], width: int) : int[][][] =
        let mutable jflow = 0
        let mutable jret : int[][][] = Unchecked.defaultof<int[][][]>
        try
            let mutable pointFactory : PointFactory = PointFactory.getInstance()
            let mutable pointBasicArrayList : BasicArrayList = null
            let mutable nextPoints : int[][] = null
            let mutable size2 : int = 0
            let mutable size : int = points.Length
            let mutable pointsBasicArrayList : BasicArrayList = (new BasicArrayListS(size))
            let mutable frame : int = 0
            while frame < size do
                nextPoints <- points.[frame]
                size2 <- nextPoints.Length
                pointBasicArrayList <- (new BasicArrayListS(size2))
                let mutable index : int = 0
                while index < size2 do
                    ignore (pointBasicArrayList.add(pointFactory.createXY(nextPoints.[index].[0], nextPoints.[index].[1])))
                    index <- index + 1
                ignore (pointsBasicArrayList.add(pointBasicArrayList))
                frame <- frame + 1
            let mutable index : int = 0
            while index < points.Length do
                ignore (pointsBasicArrayList.add(this.getInstance((box (pointsBasicArrayList.objectArray.[index]) :?> BasicArrayList), width)))
                index <- index + 1
            let mutable newPoints : int[][][] = this.vectorAnimationUtil.toAnimationArrayFromListOfPointList(pointsBasicArrayList)
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
    
    abstract getInstance : pointBasicArrayList: BasicArrayList * width: int -> BasicArrayList
    default this.getInstance(pointBasicArrayList: BasicArrayList, width: int) : BasicArrayList =
        let mutable graphicsPipe : BasicGraphicsPipeline = (new BasicGraphicsPipeline(pointBasicArrayList))
        graphicsPipe.createMatrix()
        graphicsPipe.mirror(width)
        graphicsPipe.getMatrix()


