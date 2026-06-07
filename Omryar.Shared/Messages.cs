using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Shared
{
    public static class Messages
    {
        public static class DrugNameMessage
        {
            public static string IsEmptyOrNull => "لطفا نام دارو را وارد کنید";
            public static string InvalidLength => "نام دارو باید بیشتر از سه حرف باشد";

        }
        public static class DrugDosageMessage
        {
            public static string IsEmptyOrNull => "لطفا تعداد بسته های قرص را مشخص کنید";
        }
        public static class MedicationPillCountMessage
        {
            public static string IsEmptyOrNull => "لطفا تعداد قرص ها را مشخص کنید";
        }
        public static class DrugRepeatValueMessage
        {
            public static string IsEmptyOrNull => "لطفا مقدار تکرار دارو را مشخص کنید";
        }
        public static class Drug
        {
            public static string ReminderRepeatType => "لطفا نوع تکرار یادآوری را مشخص کنید";
            public static string Qestion => "آیا از حذف این دارو اطمینان دارید؟";
            public static string RecordSuccess => "دارو با موفقیت ثبت شد";
            public static string IsEmptyOrNullBasteCountOrPillCount => "لطفا تمامی اطلاعات را وارد کنید";
            public static string IsEmptyOrNullCondition => "لطفا زمان مصرف دارو را مشخص کنید";
            public static string IsNotValidBasteCount => "تعداد بسته معتبر نیست";
            public static string IsNotValidPillCount => "تعداد قرص معتبر نیست";
            public static string IsNotValidUseTime => "زمان مصرف معتبر نیست";
            public static string IsDuplicateDrugName => "!دارویی با این نام در لیست یادآوری ثبت شده است";
        }
        public static class FullNameMessages
        {
            public static string IsEmptyOrNull => "نام و نام خانوادگی نمی‌تواند خالی باشد.";
            public static string InvalidLength => "نام و نام خانوادگی باید بیشتر از سه حرف باشد"; 
        }
        public static class NationalCodeMessages
        {
            public static string IsEmptyOrNull => "لطفا کدملی را وارد کنید";
            public static string InvalidLength => "کدملی نامعتبر است";
            public static string DuplicateNationalCode => "کدملی تکراری است";

        }
        public static class MobileMessages
        {
            public static string IsEmptyOrNull => "لطفا شماره موبایل را وارد کنید";
            public static string InvalidLength => "شماره موبایل باید ۱۱ رقم باشد.";
            public static string StartWith => "شماره موبایل باید با 09 شروع شود.";
            public static string OnlyNumber => "شماره موبایل فقط می‌تواند شامل اعداد باشد.";

        }
        public static class UserNameMessages
        {
            public static string IsEmptyOrNull => "لطفا نلم کاربری را وارد کنید";
            public static string InvalidLength => "نام کاربری باید بین 3 تا 20 کاراکتر باشد.";
            public static string StartWith => "نام کاربری نباید با خط تیره یا زیرخط شروع یا تمام شود";
            public static string InvalidCharacters => "نام کاربری فقط می‌تواند شامل حروف الفبا (a-z, A-Z)، اعداد (0-9)، خط تیره (-) و زیرخط (_) باشد.";
            public static string DuplicateUserName => "نام کاربری تکراری است";

        }
        public static string PersonlistIsEmpty => "لیست اشخاص خالی است";
        public static class PasswordMessages
        {
            public static string IsEmptyOrNull => "رمز عبور نمی‌تواند خالی باشد.";
            public static string TooShort => "رمز عبور باید حداقل 4 کاراکتر باشد.";
            public static string RequiresUppercase => "رمز عبور باید حداقل شامل یک حرف بزرگ انگلیسی (A-Z) باشد.";
            public static string RequiresLowercase => "رمز عبور باید حداقل شامل یک حرف کوچک انگلیسی (a-z) باشد.";
            public static string RequiresDigit => "رمز عبور باید حداقل شامل یک عدد (0-9) باشد.";
            public static string WrongPassword => "رمز عبور اشتباه است";
            public static string PasswordChanged => "رمز عبور با موفقیت تغییر کرد";
            public static string RequiresSpecialChar => "رمز عبور باید حداقل شامل یکی از کاراکترهای خاص (!@#$%^&*()_+=-`~[]\\|;:'\",./<>?) باشد.";
        }
        public static class ReportMessages
        {
            public static string DeleteIsComplete => "گزارش مورد نطر به صورت کامل حذف شد.";
            public static string ReportNotFound => "گزارش مورد نظر وجود ندارد.";
            public static string ReportIsDeleted => "گزارش حذف شد";
            public static string ReportUpdated => "گزارش آپدیت شد";
            public static string DeleteQuestion => "آیا از حذف این گزارش اطمینان دارید؟";
            public static string DuplicateReport => "برای این تاریخ قبلاً گزارش ثبت شده";


        }
        public static class SettingMessages
        {
            public static string SettingUpdated => "تنظیمات اپدیت شد";
            public static string Error => "خطا در ثبت تنظیمات";
            public static string SettingNotFound => "تنظیمات مورد نظر یافت نشد";

        }
        public static class VisitMessages
        {
            public static string VisitAdded => "ویزیت با موفقیت ثبت شد.";

            public static string VisitUpdated => "ویزیت با موفقیت ویرایش شد.";

            public static string VisitDeleted => "ویزیت با موفقیت حذف شد.";

            public static string VisitNotFound => "ویزیت موردنظر یافت نشد.";

            public static string DeleteQuestion => "آیا از حذف این ویزیت اطمینان دارید؟";

            public static string ReminderTitle => "یادآوری ویزیت";

            public static string UpcomingVisitReminder => "شما در 24 ساعت آینده ویزیت ثبت‌شده دارید.";

            public static string VisitMarkedAsDone => "وضعیت ویزیت با موفقیت ثبت شد.";

            public static string NotificationRegistered => "یادآوری این ویزیت ثبت شد.";

            public static string NoUpcomingVisits => "هیچ ویزیتی در 24 ساعت آینده وجود ندارد.";
            public static string VisitValidationFailed => "اطلاعات وارد شده معتبر نیست.";

            public static string DoctorNameRequired => "نام پزشک الزامی است.";

            public static string SpecialtyRequired => "تخصص پزشک الزامی است.";

            public static string InvalidVisitDate => "تاریخ و ساعت ویزیت معتبر نیست.";

            public static string PastVisitDate => "زمان ویزیت نمی‌تواند در گذشته باشد.";
        }
        public static string PersonNotFound => "این شخص پیدا نشد";
        public static string UserNameNotFound => "این نام کاربری پیدا نشد";
        public static string WrongPassword => "رمز عبور اشتباه است";
        public static string SystemError => "خطای سیستمی رخ داده";

    }
}
