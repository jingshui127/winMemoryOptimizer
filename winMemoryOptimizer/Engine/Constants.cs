namespace winMemoryOptimizer {
  
  internal static class Constants {
    
    public static class Windows {
      public static class Privilege {
        public const string SeDebugName = "SeDebugPrivilege"; // 用于调试和调整其他账户拥有的进程内存。用户权限：调试程序。

        public const string SeIncreaseQuotaName = "SeIncreaseQuotaPrivilege"; // 用于增加分配给进程的配额。用户权限：调整进程的内存配额。

        public const string SeProfSingleProcessName = "SeProfileSingleProcessPrivilege"; // 用于收集单个进程的性能分析信息。用户权限：分析单个进程。
      }

      public static class PrivilegeAttribute {
        public const int Enabled = 2; // 启用权限
      }

      public static class SystemErrorCode {
        public const int ErrorAccessDenied = 5; // (ERROR_ACCESS_DENIED) 访问被拒绝
        public const int ErrorSuccess = 0; // (ERROR_SUCCESS) 操作成功完成
      }

      public static class SystemInformationClass {
        public const int SystemCombinePhysicalMemoryInformation = 130; // 0x82 - 系统合并物理内存信息
        public const int SystemFileCacheInformation = 21; // 0x15 - 系统文件缓存信息
        public const int SystemMemoryListInformation = 80; // 0x50 - 系统内存列表信息
        public const int SystemRegistryReconciliationInformation = 155; // 0x9B - 系统注册表协调信息
      }

      public static class SystemMemoryListCommand {
        public const int MemoryFlushModifiedList = 3; // 刷新修改页列表
        public const int MemoryPurgeLowPriorityStandbyList = 5; // 清除低优先级备用列表
        public const int MemoryPurgeStandbyList = 4; // 清除备用列表
      }

      public static class Drive {
        public const int FsctlDiscardVolumeCache = 589828; // 0x00090054 - FSCTL_DISCARD_VOLUME_CACHE - 丢弃卷缓存
        public const int IoControlResetWriteOrder = 589832; // 0x000900F8 - FSCTL_RESET_WRITE_ORDER - 重置写入顺序
      }

      public static class File {
        public const int FlagsNoBuffering = 536870912; // 0x20000000 - FILE_FLAG_NO_BUFFERING - 无缓冲标志
      }
    }
  }
}