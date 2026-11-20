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
type MineLayerFactory =
    [<DefaultValue(false)>] val mutable viewPositionFactoryInterface : ViewPositionFactoryInterface
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MineLayerFactory.jclinitDone then
            MineLayerFactory.jclinitDone <- true
            MineLayerFactory.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    
    new (viewPositionFactoryInterface: ViewPositionFactoryInterface) as this =
        {  }
        then
            this.jctor1(viewPositionFactoryInterface)
    member this.jctor1(viewPositionFactoryInterface: ViewPositionFactoryInterface) : unit =
        this.viewPositionFactoryInterface <- viewPositionFactoryInterface
        ()
    
    abstract getInstance : unit -> AllBinaryLayer
    default this.getInstance() : AllBinaryLayer =
        (new MineLayer(this.viewPositionFactoryInterface.getInstance()))
    interface AllBinaryLayerFactoryInterface with
        member this.getInstance() : AllBinaryLayer = this.getInstance()


