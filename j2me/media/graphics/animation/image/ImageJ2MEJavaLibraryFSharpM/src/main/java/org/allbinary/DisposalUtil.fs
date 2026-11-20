namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2022 AllBinary 
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
type DisposalUtil =
    [<DefaultValue(false)>] static val mutable private jcell_instance : DisposalUtil
    static member instance with get() : DisposalUtil = (DisposalUtil.jclinit(); DisposalUtil.jcell_instance) and set (jvalue: DisposalUtil) = (DisposalUtil.jclinit(); DisposalUtil.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not DisposalUtil.jclinitDone then
            DisposalUtil.jclinitDone <- true
            DisposalUtil.jclinitBody()
    static member private jclinitBody() : unit =
        DisposalUtil.jcell_instance <- (new DisposalUtil())
        ()
    new () =
        {  }
    
    static member getInstance() : DisposalUtil =
        DisposalUtil.instance
    
    abstract disposeImage : image: Image -> unit
    default this.disposeImage(image: Image) : unit =
        ()
    
    abstract disposeResource : resource: Resource -> unit
    default this.disposeResource(resource: Resource) : unit =
        if not (resource.isDisposed()) then
            resource.dispose()


