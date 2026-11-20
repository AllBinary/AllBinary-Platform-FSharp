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
type BasicGraphicsPipeline =
    [<DefaultValue(false)>] val mutable pointBasicArrayList : BasicArrayList
    [<DefaultValue(false)>] val mutable noDecimalTrigTable : NoDecimalTrigTable
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not BasicGraphicsPipeline.jclinitDone then
            BasicGraphicsPipeline.jclinitDone <- true
            BasicGraphicsPipeline.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_BasicGraphicsPipeline() : unit =
        this.noDecimalTrigTable <- NoDecimalTrigTable.getInstance()
        ()
    
    new (points: BasicArrayList) as this =
        {  }
        then
            this.jfields_BasicGraphicsPipeline()
            this.jctor1(points)
    member this.jctor1(points: BasicArrayList) : unit =
        this.pointBasicArrayList <- points
        ()
    
    abstract setInitMatrix : points: BasicArrayList -> unit
    default this.setInitMatrix(points: BasicArrayList) : unit =
        this.pointBasicArrayList <- points
    
    abstract createMatrix : unit -> unit
    default this.createMatrix() : unit =
        ()
    
    abstract translate : x: int * y: int -> unit
    default this.translate(x: int, y: int) : unit =
        let mutable newBasicArrayList : BasicArrayList = (new BasicArrayListD())
        let mutable size : int = this.pointBasicArrayList.size()
        let mutable pointFactory : PointFactory = PointFactory.getInstance()
        let mutable secondPoint : GPoint = null
        let mutable index : int = 0
        while index < size do
            secondPoint <- (box (this.pointBasicArrayList.objectArray.[index]) :?> GPoint)
            if secondPoint.getX() <> 1000 then
                ignore (newBasicArrayList.add(pointFactory.createXY((secondPoint.getX() + x), (secondPoint.getY() + y))))
            else
                ignore (newBasicArrayList.add(secondPoint))
            index <- index + 1
        this.pointBasicArrayList <- newBasicArrayList
    
    abstract rotateToAngle : angle: Angle -> unit
    default this.rotateToAngle(angle: Angle) : unit =
        this.rotate(int (angle.getValue()))
    
    member this.rotate(angle: int) : unit =
        let mutable newBasicArrayList : BasicArrayList = (new BasicArrayListD())
        let mutable secondPoint : GPoint = null
        let mutable y : int64 = 0L
        let mutable secondX : int64 = 0L
        let mutable secondY : int64 = 0L
        let mutable point : GPoint = null
        let mutable pointFactory : PointFactory = PointFactory.getInstance()
        let mutable size : int = this.pointBasicArrayList.size()
        let mutable sin : int64 = 0L
        let mutable cos : int64 = 0L
        let mutable index : int = 0
        while index < size do
            secondPoint <- (box (this.pointBasicArrayList.objectArray.[index]) :?> GPoint)
            if secondPoint.getX() <> 1000 then
                sin <- this.noDecimalTrigTable.sin(angle)
                cos <- this.noDecimalTrigTable.cos(angle)
                y <- int64 (secondPoint.getY()) * sin
                secondX <- (int64 (secondPoint.getX()) * cos) - y
                secondY <- (int64 (secondPoint.getX()) * sin) + (int64 (secondPoint.getY()) * cos)
                point <- pointFactory.createXY((int (secondX) / 10000), (int (secondY) / 10000))
                ignore (newBasicArrayList.add(point))
            else
                ignore (newBasicArrayList.add(secondPoint))
            index <- index + 1
        this.pointBasicArrayList <- newBasicArrayList
    
    abstract mirror : width: int -> unit
    default this.mirror(width: int) : unit =
        let mutable pointFactory : PointFactory = PointFactory.getInstance()
        let mutable halfWidth : int = (width >>> 1)
        let mutable newBasicArrayList : BasicArrayList = (new BasicArrayListD())
        let mutable secondPoint : GPoint = null
        let mutable newX : int = 0
        let mutable point : GPoint = null
        let mutable size : int = this.pointBasicArrayList.size()
        let mutable index : int = 0
        while index < size do
            secondPoint <- (box (this.pointBasicArrayList.objectArray.[index]) :?> GPoint)
            if secondPoint.getX() <> 1000 then
                newX <- 0
                if secondPoint.getX() > halfWidth then
                    newX <- halfWidth - (secondPoint.getX() - halfWidth)
                else
                    newX <- halfWidth + (halfWidth - secondPoint.getX())
                point <- pointFactory.createXY(newX, secondPoint.getY())
                ignore (newBasicArrayList.add(point))
            else
                ignore (newBasicArrayList.add(secondPoint))
            index <- index + 1
        this.pointBasicArrayList <- newBasicArrayList
    
    abstract getMatrix : unit -> BasicArrayList
    default this.getMatrix() : BasicArrayList =
        this.pointBasicArrayList


