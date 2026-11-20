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
type GameLayerUtil =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not GameLayerUtil.jclinitDone then
            GameLayerUtil.jclinitDone <- true
            GameLayerUtil.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new () =
        {  }
    
    static member isOnScreen(layer: AllBinaryLayer) : bool =
        let mutable displayInfo : DisplayInfoSingleton = DisplayInfoSingleton.getInstance()
        let mutable viewPosition : ViewPositionBase = layer.getViewPosition()
        GameLayerUtil.isInside(viewPosition.getX(), viewPosition.getY(), viewPosition.getX2(), viewPosition.getY2(), 0, 0, displayInfo.getLastWidth(), displayInfo.getLastHeight())
    
    static member isInside(rectX1: int, rectY1: int, rectX2: int, rectY2: int, rect2X1: int, rect2Y1: int, rect2X2: int, rect2Y2: int) : bool =
        let mutable jflow = 0
        let mutable jret : bool = Unchecked.defaultof<bool>
        if (((rectX1 > rect2X1) && (rectX2 < rect2X2)) && (rectY1 > rect2Y1)) && (rectY2 < rect2Y2) then
            jret <- true
            jflow <- 1
        else
            jret <- false
            jflow <- 1
        jret


