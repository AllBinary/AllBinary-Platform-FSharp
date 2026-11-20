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
type AllBinaryRendererBase3 =
    [<DefaultValue(false)>] val mutable list : BasicArrayList
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not AllBinaryRendererBase3.jclinitDone then
            AllBinaryRendererBase3.jclinitDone <- true
            AllBinaryRendererBase3.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () as this =
        {  }
        then
            this.jfields_AllBinaryRendererBase3()
    member this.jfields_AllBinaryRendererBase3() : unit =
        this.list <- (new BasicArrayListD())
        ()
    
    abstract update : gl: GL10 -> unit
    default this.update(gl: GL10) : unit =
        while this.list.size() > 0 do
            let mutable openGLESImage : OpenGLESImage = (box (this.list.removeAt(0)) :?> OpenGLESImage)
            if not (JR.same(openGLESImage, null)) then
                openGLESImage.set(gl)
    
    abstract add : image: Image -> unit
    default this.add(image: Image) : unit =
        ignore (this.list.add(image))


