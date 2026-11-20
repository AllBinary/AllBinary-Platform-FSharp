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
type SWTJOGLProcessor =
    [<DefaultValue(false)>] val mutable glHolder : GLHolder
    [<DefaultValue(false)>] static val mutable private jcell_instance : SWTJOGLProcessor
    static member instance with get() : SWTJOGLProcessor = (SWTJOGLProcessor.jclinit(); SWTJOGLProcessor.jcell_instance) and set (jvalue: SWTJOGLProcessor) = (SWTJOGLProcessor.jclinit(); SWTJOGLProcessor.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not SWTJOGLProcessor.jclinitDone then
            SWTJOGLProcessor.jclinitDone <- true
            SWTJOGLProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        SWTJOGLProcessor.jcell_instance <- (new SWTJOGLProcessor())
        ()
    new () as this =
        {  }
        then
            this.jfields_SWTJOGLProcessor()
    member this.jfields_SWTJOGLProcessor() : unit =
        this.glHolder <- (new SWTJOGLProcessor_jAnon1(this))
        ()
    
    static member getInstance() : SWTJOGLProcessor =
        SWTJOGLProcessor.instance
    
    abstract init : display: obj * comp: obj -> unit
    default this.init(display: obj, comp: obj) : unit =
        ()
    
    abstract isHolderCreated : unit -> bool
    default this.isHolderCreated() : bool =
        this.glHolder.isCreated
    
    abstract setRenderer : renderer: obj -> unit
    default this.setRenderer(renderer: obj) : unit =
        ()
    
    abstract isJOGL : unit -> bool
    default this.isJOGL() : bool =
        false
    
    abstract createSurface : unit -> unit
    default this.createSurface() : unit =
        ()
    
    abstract onSurfaceCreated : unit -> unit
    default this.onSurfaceCreated() : unit =
        ()
    
    abstract onSurfaceChangedForEvent : event_: obj -> unit
    default this.onSurfaceChangedForEvent(event_: obj) : unit =
        ()
    
    abstract onSurfaceChanged : unit -> unit
    default this.onSurfaceChanged() : unit =
        ()
    
    abstract onSurfaceChangedWH : width: int * height: int -> unit
    default this.onSurfaceChangedWH(width: int, height: int) : unit =
        ()
    
    abstract addListener : unit -> unit
    default this.addListener() : unit =
        ()
    
    abstract addListeners : midlet: MIDlet -> unit
    default this.addListeners(midlet: MIDlet) : unit =
        ()
    
    abstract run : unit -> unit
    default this.run() : unit =
        ()
    
    abstract clear : unit -> unit
    default this.clear() : unit =
        ()
    
    abstract setCustom : width: int * height: int * ratio: float32 -> unit
    default this.setCustom(width: int, height: int, ratio: float32) : unit =
        ()
    
    abstract setRatioProcessor : ratioProcessor: RatioProcessor -> unit
    default this.setRatioProcessor(ratioProcessor: RatioProcessor) : unit =
        ()
    
    abstract charWidth : font: Font * ch: char -> int
    default this.charWidth(font: Font, ch: char) : int =
        raise ((new JRuntimeException()))
    
    abstract charsWidth : font: Font * ch: char[] * offset: int * length: int -> int
    default this.charsWidth(font: Font, ch: char[], offset: int, length: int) : int =
        raise ((new JRuntimeException()))
    
    abstract stringWidth : font: Font * str: string -> int
    default this.stringWidth(font: Font, str: string) : int =
        raise ((new JRuntimeException()))
    
    abstract substringWidth : font: Font * str: string * offset: int * len: int -> int
    default this.substringWidth(font: Font, str: string, offset: int, len: int) : int =
        raise ((new JRuntimeException()))
    interface Runnable with
        member this.run() : unit = this.run()


[<AllowNullLiteral>]
type SWTJOGLProcessor_jAnon1 =
    inherit GLHolder
    [<DefaultValue(false)>] val mutable jouter : SWTJOGLProcessor
    new (jouter: SWTJOGLProcessor) as this =
        { inherit GLHolder() }
        then
            this.jouter <- jouter
            ()
    override this.run(renderer: obj) : unit =
        ()


