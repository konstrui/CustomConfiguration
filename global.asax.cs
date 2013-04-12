protected void Application_Start(object sender, EventArgs e) {

  Bootstrapper.Initialized += new EventHandler<Telerik.Sitefinity.Data.ExecutedEventArgs>(Bootstrapper_Initialized);


}

void Bootstrapper_Initialized(object sender, Telerik.Sitefinity.Data.ExecutedEventArgs e) {

    Config.RegisterSection<FalafelConfig>();

}
