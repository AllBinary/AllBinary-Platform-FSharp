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
type RectangleCollisionPointUtil =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not RectangleCollisionPointUtil.jclinitDone then
            RectangleCollisionPointUtil.jclinitDone <- true
            RectangleCollisionPointUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        {  }
    
    static member allPointsInside(rectX1: int, rectY1: int, rectX2: int, rectY2: int, list_: BasicArrayList) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable rectangleCollisionUtil : RectangleCollisionUtil = RectangleCollisionUtil.getInstance()
        let mutable point : GPoint = null
        let mutable index : int = list_.size()
        while jflow = 0 && (((index <- index - 1; index)) >= 0) do
            point <- (box (list_.objectArray.[index]) :?> GPoint)
            if not (rectangleCollisionUtil.isInside(rectX1, rectY1, rectX2, rectY2, point.getX(), point.getY())) then
                jret <- false
                jflow <- 1
            if jflow = 200001 then jflow <- 0
        if jflow = 100001 then jflow <- 0
        if jflow = 0 then
            jret <- true
            jflow <- 1
        jret
    
    static member allPointsInsideCell(rectX1: int, rectY1: int, rectX2: int, rectY2: int, list_: BasicArrayList, xCellSize: int, yCellSize: int) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        let mutable rectangleCollisionUtil : RectangleCollisionUtil = RectangleCollisionUtil.getInstance()
        let mutable point : GPoint = null
        let mutable index : int = list_.size()
        while jflow = 0 && (((index <- index - 1; index)) >= 0) do
            point <- (box (list_.objectArray.[index]) :?> GPoint)
            if not (rectangleCollisionUtil.isInside(rectX1, rectY1, rectX2, rectY2, (point.getX() * xCellSize), (point.getY() * yCellSize))) then
                jret <- false
                jflow <- 1
            if jflow = 200002 then jflow <- 0
        if jflow = 100002 then jflow <- 0
        if jflow = 0 then
            jret <- true
            jflow <- 1
        jret


