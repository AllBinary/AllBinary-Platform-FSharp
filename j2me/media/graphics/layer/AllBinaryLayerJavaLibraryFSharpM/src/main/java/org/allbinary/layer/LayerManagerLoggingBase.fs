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
type LayerManagerLoggingBase =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not LayerManagerLoggingBase.jclinitDone then
            LayerManagerLoggingBase.jclinitDone <- true
            LayerManagerLoggingBase.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract append : layerInterface: AllBinaryLayer -> unit
    default this.append(layerInterface: AllBinaryLayer) : unit =
        ()
    
    abstract appendAt : layerInterface: AllBinaryLayer * index: int -> unit
    default this.appendAt(layerInterface: AllBinaryLayer, index: int) : unit =
        ()
    
    abstract remove : layerInterface: AllBinaryLayer -> unit
    default this.remove(layerInterface: AllBinaryLayer) : unit =
        ()
    
    abstract removeResult : layerManager: LayerManager * layerInterface: AllBinaryLayer * result: bool -> unit
    default this.removeResult(layerManager: LayerManager, layerInterface: AllBinaryLayer, result: bool) : unit =
        ()
    
    abstract clear : unit -> unit
    default this.clear() : unit =
        ()


