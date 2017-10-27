namespace WinniesService
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.WinniesService = new System.ServiceProcess.ServiceProcessInstaller();
            this.instaladerWinnies = new System.ServiceProcess.ServiceInstaller();
            // 
            // WinniesService
            // 
            this.WinniesService.Account = System.ServiceProcess.ServiceAccount.NetworkService;
            this.WinniesService.Password = null;
            this.WinniesService.Username = null;
            // 
            // instaladerWinnies
            // 
            this.instaladerWinnies.ServiceName = "WinniesService";
            this.instaladerWinnies.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.WinniesService,
            this.instaladerWinnies});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller WinniesService;
        private System.ServiceProcess.ServiceInstaller instaladerWinnies;
    }
}