namespace rec AllBinary

// Generated Code Do Not Modify
(*
 * 
 * AllBinary Open License Version 1 
 * Copyright (c) 2025 AllBinary 
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
type MyFontProcessor =
    [<DefaultValue(false)>] static val mutable private jcell_instance : MyFontProcessor
    static member instance with get() : MyFontProcessor = (MyFontProcessor.jclinit(); MyFontProcessor.jcell_instance) and set (jvalue: MyFontProcessor) = (MyFontProcessor.jclinit(); MyFontProcessor.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not MyFontProcessor.jclinitDone then
            MyFontProcessor.jclinitDone <- true
            MyFontProcessor.jclinitBody()
    static member private jclinitBody() : unit =
        MyFontProcessor.jcell_instance <- (new MyFontProcessor())
        ()
    new () =
        {  }
    
    static member defaultCharWidth(font: Font) : int =
        font.charWidth('C')
    
    static member defaultStringWidth(font: Font, size: int) : int =
        MyFontProcessor.defaultCharWidth(font) * size
    
    static member getInstance() : MyFontProcessor =
        MyFontProcessor.instance
    
    abstract process_ : graphics: Graphics -> unit
    default this.process_(graphics: Graphics) : unit =
        ()


