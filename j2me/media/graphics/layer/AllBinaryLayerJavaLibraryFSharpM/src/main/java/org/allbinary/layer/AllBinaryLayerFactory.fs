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
type AllBinaryLayerFactory =
    [<DefaultValue(false)>] val mutable rectangle : Rectangle
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AllBinaryLayerFactory.jclinitDone then
            AllBinaryLayerFactory.jclinitDone <- true
            AllBinaryLayerFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (rectangle: Rectangle) as this =
        {  }
        then
            this.jctor1(rectangle)
    member this.jctor1(rectangle: Rectangle) : unit =
        this.rectangle <- rectangle
        ()
    
    abstract getInstance : unit -> AllBinaryLayer
    default this.getInstance() : AllBinaryLayer =
        (new AllBinaryLayer(StringUtil.getInstance().EMPTY_STRING, this.rectangle, ViewPosition.getInstanceD()))
    interface AllBinaryLayerFactoryInterface with
        member this.getInstance() : AllBinaryLayer = this.getInstance()


