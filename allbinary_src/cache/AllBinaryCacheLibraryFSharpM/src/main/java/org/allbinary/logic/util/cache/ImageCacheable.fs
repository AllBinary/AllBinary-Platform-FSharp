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
type ImageCacheable =
    [<DefaultValue(false)>] val mutable name : string
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not ImageCacheable.jclinitDone then
            ImageCacheable.jclinitDone <- true
            ImageCacheable.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    member this.jfields_ImageCacheable() : unit =
        this.name <- StringUtil.getInstance().EMPTY_STRING
        ()
    
    new (name: string, anyType: obj) as this =
        {  }
        then
            this.jfields_ImageCacheable()
    
    abstract getKey : unit -> obj
    default this.getKey() : obj =
        this.name
    
    override this.ToString() : string =
        this.name


