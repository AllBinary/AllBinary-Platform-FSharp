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
type OpenGLOptions =
    [<DefaultValue(false)>] static val mutable private jclinitDone : bool
    static member jclinit() : unit =
        if not OpenGLOptions.jclinitDone then
            OpenGLOptions.jclinitDone <- true
            OpenGLOptions.jclinitBody()
    static member private jclinitBody() : unit =
        ()
    new () =
        {  }
    
    abstract init : unit -> unit
    default this.init() : unit =
        let mutable openGLFeatureFactory : OpenGLFeatureFactory = OpenGLFeatureFactory.getInstance()
        if Features.getInstance().isFeature(openGLFeatureFactory.OPENGL_OPTIONS) then
            let mutable openGLMultipleList : BasicArrayList = (new BasicArrayListD())
            ignore (openGLMultipleList.add(openGLFeatureFactory.OPENGL))
            GameFeatureChoiceGroups.getMultipleInstance().add("OpenGL (Complete Restart)", openGLMultipleList)
            let mutable openGLVersionSelectorMultipleList : BasicArrayList = (new BasicArrayListD())
            ignore (openGLVersionSelectorMultipleList.add(openGLFeatureFactory.OPENGL_AUTO_SELECT))
            ignore (openGLVersionSelectorMultipleList.add(openGLFeatureFactory.OPENGL_MINIMUM))
            GameFeatureChoiceGroups.getExclusiveInstance().add("OpenGL Version Selector", openGLVersionSelectorMultipleList)
            let mutable openGLImageColorMultipleList : BasicArrayList = (new BasicArrayListD())
            ignore (openGLImageColorMultipleList.add(openGLFeatureFactory.IMAGE_COLOR_DEPTH_4444))
            ignore (openGLImageColorMultipleList.add(openGLFeatureFactory.IMAGE_COLOR_DEPTH_8888))
            GameFeatureChoiceGroups.getExclusiveInstance().add("OpenGL Image Color RGBA", openGLImageColorMultipleList)


