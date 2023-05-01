namespace mis_221_pa_5_Raiinwater21
{
    public class TrainerData
    {
        private string ManagerTrainerId; // randomly generated 9 digits numbers
        private string ManageTrainerFirstName;
        private string ManageTrainerLastName;
        private string ManageTrainerMailing;
        private string ManageTrainerEmail; // randomly generated emails @
        private string ManageTrainerPhone; // randomly generated 205 #
        private string ManageTrainerType; // str / conditioning / old people / crossfit / diet / class / cycling / yoga / 
        private string ManageTrainerTime; // morning midday evening nighttime
        //public static string ManageTrainerData();
        public void SetTrainerId(string TrainerId){
            this.ManagerTrainerId = TrainerId;
        }
         public string GetTrainerId()
        {
            return ManagerTrainerId;
        }
        public void SetTrainerFirstName(string TrainerFirstName){
            this.ManageTrainerFirstName = TrainerFirstName;
        }
        public string GetTrainerFirstName(){
            return ManageTrainerFirstName;
        }        
        public void SetTrainerLastName(string TrainerLastName){
            this.ManageTrainerLastName = TrainerLastName;
        }
        public string GetTrainerFirstLastName(){
            return ManageTrainerFirstName;
        }
        public void SetTrainerMailing(string TrainerMailing){
            this.ManageTrainerMailing = TrainerMailing;
        }
        public string GetTrainerMailing(){
            return ManageTrainerMailing;
        }
        public void SetTrainerEmail(string TrainerEmail){
            this.ManageTrainerEmail = TrainerEmail;
        }
        public string GetTrainerEmail(){
            return ManageTrainerEmail;
        }
        public void SetTrainerPhone(string TrainerPhone){
            this.ManageTrainerPhone = TrainerPhone;
        }
        public string GetTrainerPhone(){
            return ManageTrainerPhone;
        }
        public void SetTrainerType(string TrainerType){
            this.ManageTrainerType = TrainerType;
        }
        public string GetTrainerType(){
            return ManageTrainerType;
        }
        public void SetTrainerTime(int TrainerTime){
            this.ManageTrainerTime = TrainerTime;
        }
        public int GetTrainerTime(){
            return ManageTrainerTime;
        } 
    }
}