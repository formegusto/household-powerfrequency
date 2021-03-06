using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hhpf.Common
{
	public static class COMMON_ACTIONS
	{
		public const string START_LOADING = "start_loading";
		public const string STOP_LOADING = "stop_loading";
	}
	public static class VIEW_ACTIONS
	{
		public const string CHANGE_KEYWORD = "change_keyword";
		public const string CHANGE_DAY = "change_day";
		public const string CHANGE_TIMESLOT = "change_timeslot";
		public const string CHANGE_SEASON = "change_season";

		public const string AUTO_DRAW = "auto_draw";
		public const string AUTO_DRAW_SUCCESS = "auto_draw/success";
		public const string AUTO_DRAW_FAILURE = "auto_draw/failure";
		public const string AUTO_DRAW_LAST = "auto_draw/last";

		public const string AUTO_LOAD = "auto_load";
		public const string AUTO_LOAD_SUCCESS = "auto_load_success";
		public const string AUTO_LOAD_FAILURE = "auto_load_failure";
		public const string AUTO_LOAD_NEXT = "auto_load_next";
		public const string AUTO_LOAD_NEXT_SUCCESS = "auto_load_next_success";
		public const string AUTO_LOAD_NEXT_FAILURE = "auto_load_next_failure";
		public const string AUTO_LOAD_LAST = "auto_load_last";

		public const string REQUEST_DAYDATA = "request_daydata/pending";
		public const string REQUEST_DAYDATA_SUCCESS = "request_daydata/success";
		public const string REQUEST_DAYDATA_FAILURE = "request_daydata/failure";

		public const string REQUEST_SIMILARDATA = "request_similardata/pending";
		public const string REQUEST_SIMILARDATA_SUCCESS = "request_similardata/success";
		public const string REQUEST_SIMILARDATA_FAILURE = "request_similardata/failure";

		public const string REQUEST_SIMPF = "request_simpf/pending";
		public const string REQUEST_SIMPF_SUCCESS = "request_simpf/success";
		public const string REQUEST_SIMPF_FAILURE = "request_simpf/failure";
	}

	public static class MODEL_ACTIONS
	{
		public const string LOAD_EXCEL = "load_excel/pending";
		public const string LOAD_EXCEL_SUCCESS = "load_excel/sucess";
		public const string LOAD_EXCEL_FAILURE = "load_excel/failure";
		public const string LOAD_EXCEL_NOT_FOUND = "load_excel/notfound";

		public const string REQUIRE_RELOAD = "require_reload";
	}
}
