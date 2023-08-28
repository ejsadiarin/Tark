import {
  Card,
  CardContent,
  CardDescription,
  CardFooter,
  CardHeader,
  CardTitle,
} from "@/components/ui/card"
import { Separator } from "@/components/ui/separator"

export default function Home() {
  return (
    <>
      <div className="flex flex-col items-center w-full border-black p-5 pt-7">
        <h1>Welcome to Tark</h1>
        <p>The modern project management solution for perfectionists.</p>
        <Card className="w-[350px] h-[350px]">
          <CardTitle>Test </CardTitle>

        </Card>


      </div>
    </>
  )
}
