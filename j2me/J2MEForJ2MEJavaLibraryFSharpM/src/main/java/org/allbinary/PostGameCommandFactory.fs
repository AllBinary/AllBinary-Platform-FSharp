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
type PostGameCommandFactory =
    [<DefaultValue(false)>] static val mutable private jcell_instance : PostGameCommandFactory
    static member instance with get() : PostGameCommandFactory = (PostGameCommandFactory.jclinit(); PostGameCommandFactory.jcell_instance) and set (jvalue: PostGameCommandFactory) = (PostGameCommandFactory.jclinit(); PostGameCommandFactory.jcell_instance <- jvalue)
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not PostGameCommandFactory.jclinitDone then
            PostGameCommandFactory.jclinitDone <- true
            PostGameCommandFactory.jclinitBody()
    static member private jclinitBody() : unit =
        PostGameCommandFactory.jcell_instance <- (new PostGameCommandFactory())
        ()
    new () =
        {  }
    
    static member getInstance() : PostGameCommandFactory =
        PostGameCommandFactory.instance
    
    abstract addCommands : canvas: MyCanvas -> unit
    default this.addCommands(canvas: MyCanvas) : unit =
        MultiPlayerGameFeatureFactory.getInstance().addCommands(canvas)


